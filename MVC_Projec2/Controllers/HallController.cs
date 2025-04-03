using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;
using MVC_Projec2.ViewModels;
using System;
using System.ComponentModel;

namespace MVC_Projec2.Controllers
{
    public class HallController : Controller

    {
        private readonly IHallRepository hallRepository;
        private readonly IImageUploadService _imageUploadService;
        private readonly ILogger<HallController> _logger;
        public HallController(IHallRepository hallRepo,IImageUploadService imageUpload, ILogger<HallController> logger)
        {
            this.hallRepository = hallRepo;
            this._imageUploadService = imageUpload;
            _logger = logger;
        }
        public IActionResult GetAll()
        {
            List<Hall> HallList = hallRepository.GetAllWithImages();

            return View("GetAll", HallList);
        }

        public IActionResult HallDetailes(int id)
        {
            Hall hall = hallRepository.GetByIdWithImages(id);
            if (hall == null)
            {
                return NotFound();
            }
            else
            {
                return View("HallDetailes", hall);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteHall(int id)
        {


            try
            {
                Hall hall = hallRepository.GetById(id);

                if (hall == null)
                {
                    return NotFound();
                }

                foreach (var image in hall.Images)
                {
                    _imageUploadService.DeleteImage(image.ImageUrl);
                }

                hallRepository.Delete(hall);
                hallRepository.Save();

                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding hall");
                ModelState.AddModelError("", "An error occurred while deleting the hall. Please try again.");

                return View("GetAll");
            }


        }


        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            return View();
        }




        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add(AddHallViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
               

                var hall = new Hall
                {
                    Name = model.Name,
                    Capacity = model.Capacity,
                    Location = model.Location,
                    Price = model.Price,
                  
                };

                foreach (var file in model.ImageFiles)
                {
                    var imagePath = await _imageUploadService.UploadImageAsync(file);
                    hall.Images.Add(new HallImage { ImageUrl = imagePath });
                }

                hallRepository.insert(hall);
                hallRepository.Save();

                TempData["SuccessMessage"] = "Hall added successfully!";
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding hall");
                ModelState.AddModelError("", "An error occurred while adding the hall.");
                return View(model);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            Hall hall = hallRepository.GetById(id);
            if (hall == null)
            {
                return NotFound();
            }

            EditHallViewModel viewModel = new EditHallViewModel
            {
                Id = hall.Id,
                Name = hall.Name,
                Capacity = hall.Capacity,
                Location = hall.Location,
                Price = (double)hall.Price,
               
            };

            return View(viewModel);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Edit(EditHallViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var hall = hallRepository.GetById(model.Id);
                if (hall == null)
                {
                    return NotFound();
                }

            
                hall.Name = model.Name;
                hall.Capacity = model.Capacity;
                hall.Location = model.Location;
                hall.Price = model.Price;
             

                hallRepository.Update(hall);
                hallRepository.Save();

                TempData["SuccessMessage"] = "Hall updated successfully!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing hall ID {HallId}", model.Id);
                ModelState.AddModelError("", "An error occurred while updating the hall.");
                return View(model);
            }
        }




    }

    }

