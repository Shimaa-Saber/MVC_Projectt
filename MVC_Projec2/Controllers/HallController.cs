﻿using Microsoft.AspNetCore.Authorization;
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
        private readonly ICommentRepository _commentRepository;

        public HallController(ICommentRepository commentRepository,
                              IHallRepository hallRepo,
                              IImageUploadService imageUpload,
                              ILogger<HallController> logger)
        {
            this._commentRepository = commentRepository;
            this.hallRepository = hallRepo;
            this._imageUploadService = imageUpload;
            _logger = logger;
        }

        public IActionResult GetAll()
        {
            return View(hallRepository.GetAllWithImages());
        }

        public IActionResult HallDetails(int id)
        {
            Hall hall = hallRepository.GetByIdWithImages(id);
            if (hall == null)
            {
                return NotFound();
            }
            else
            {
                var comments = _commentRepository.GetCommentsByService(id, ServiceType.Hall);
                var viewModel = new HallCommentViewModel
                {
                    Hall = hall,
                    Comments = comments,
                    CommentText = ""
                };

                return View(viewModel);
            }
        }

        [HttpPost]
        public IActionResult AddComment(HallCommentViewModel model)
        {
            if (string.IsNullOrEmpty(model.CommentText))
            {
                ModelState.AddModelError("", "Please provide a comment.");
                return RedirectToAction("HallDetails", new { id = model.Hall.Id });
            }

            var comment = new Comment
            {
                Content = model.CommentText,
                ServiceId = model.Hall.Id,
                CreatedAt = DateTime.Now,
                UserId = User.Identity.Name,
                ServiceType = ServiceType.Hall
            };

            _commentRepository.insert(comment);
            _commentRepository.Save();

            return RedirectToAction("HallDetails", new { id = model.Hall.Id });
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

                if (hall.Images != null && hall.Images.Count() > 0)
                {
                    foreach (var image in hall.Images)
                    {
                        _imageUploadService.DeleteImage(image.ImageUrl);
                    }

                }


                hallRepository.Delete(hall);
                hallRepository.Save();

                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting hall");
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
        public async Task<IActionResult> SaveAdd(AddHallViewModel model)
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
        [HttpPost]
        public IActionResult UpdateHall(EditHallViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", model); 
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
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing hall ID {HallId}", model.Id);
                ModelState.AddModelError("", "An error occurred while updating the hall.");
                return View("Edit", model); 
            }
        }
    }
}
