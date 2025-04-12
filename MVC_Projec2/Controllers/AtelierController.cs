using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;
using MVC_Projec2.ViewModels;

namespace MVC_Projec2.Controllers
{
    public class AtelierController : Controller
    {
        IAtelierRepository atelierRepository;
        private readonly IImageUploadService _imageUploadService;
        private readonly ILogger<HallController> _logger;
        private readonly ICommentRepository _commentRepository;

        public AtelierController(ICommentRepository commentRepository,
                              IAtelierRepository  atelierRepository,
                              IImageUploadService imageUpload,
                              ILogger<HallController> logger)
        {
            this._commentRepository = commentRepository;
            this.atelierRepository = atelierRepository;
            this._imageUploadService = imageUpload;
            _logger = logger;
        }

        public IActionResult GetAll()
        {
            return View(atelierRepository.GetAll());
        }

        public IActionResult Detail(int id)
        {
            Atelier atelier = atelierRepository.GetByIdWithImages(id);
            if (atelier == null)
            {
                return NotFound();
            }
            else
            {
                var comments = _commentRepository.GetCommentsByService(id, ServiceType.Atelier);
                var viewModel = new AtelierCommentViewModel
                {
                    Atelier= atelier,
                    Comments = comments,
                    CommentText = ""
                };

                return View(viewModel);
            }

        }



        [HttpPost]
        public IActionResult AddComment(AtelierCommentViewModel model)
        {
            if (string.IsNullOrEmpty(model.CommentText))
            {
                ModelState.AddModelError("", "Please provide a comment.");
                return RedirectToAction("AtelierDetails", new { id = model.Atelier.Id });
            }

            var comment = new Comment
            {
                Content = model.CommentText,
                ServiceId = model.Atelier.Id,
                CreatedAt = DateTime.Now,
                UserId = User.Identity.Name,
                ServiceType = ServiceType.Atelier
            };

            _commentRepository.insert(comment);
            _commentRepository.Save();

            return RedirectToAction("AtelierDetails", new { id = model.Atelier.Id });
        }

        public IActionResult Search(string searchValue)
        {
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                return RedirectToAction("GetAll");
            }

            try
            {
                var Atilers = atelierRepository.SearchByName(searchValue);
                return View("GetAll", Atilers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching Atilers");
                TempData["ErrorMessage"] = "An error occurred during search";
                return RedirectToAction("GetAll");
            }
        }




        [Authorize(Roles = "Admin")]
        public IActionResult DeleteAtelier(int id)
        {
            try
            {
                Atelier atelier = atelierRepository.GetById(id);

                if (atelier == null)
                {
                    return NotFound();
                }

                if (atelier.Images != null && atelier.Images.Count() > 0)
                {
                    foreach (var image in atelier.Images)
                    {
                        _imageUploadService.DeleteImage(image.ImageUrl);
                    }

                }


                atelierRepository.Delete(atelier);
                atelierRepository.Save();

                return RedirectToAction("GetAllAteliers", "Dashboard");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting atelier");
                ModelState.AddModelError("", "An error occurred while deleting the atelier. Please try again.");

                return View("GetAllAteliers", "Dashboard");
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SaveAdd(AddAtelierViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var atelier = new Atelier
                {
                    Name = model.Name,
                    priceRange = model.priceRange,
                    Location = model.Location
                };

                foreach (var file in model.ImageFiles)
                {
                    var imagePath = await _imageUploadService.UploadImageAsync(file);
                    atelier.Images.Add(new AtelierImages { ImageUrl = imagePath });
                }

                atelierRepository.insert(atelier);
                atelierRepository.Save();

                TempData["SuccessMessage"] = "Atalier added successfully!";
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding atalier");
                ModelState.AddModelError("", "An error occurred while adding the atalier.");
                return View(model);
            }
        }

        //[Authorize(Roles = "Admin")]
        [AllowAnonymous]
        public IActionResult Edit(int id)
        {
            Atelier atelier = atelierRepository.GetByIdWithImages(id);
            if (atelier == null)
            {
                return NotFound();
            }

            var viewModel = new EditAtelierViewModel
            {
                Images= atelier.Images,
                Name = atelier.Name,
                priceRange = atelier.priceRange,
                Location = atelier.Location,
                ImageUrl = atelier.ImageUrl,

            };

            return View(viewModel);
        }

        [AllowAnonymous]
        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult SaveEdit(EditAtelierViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("Edit", model);
            //}

            try
            {
                var atelier = atelierRepository.GetById(model.Id);
                if (atelier == null)
                {
                    return NotFound();
                }

                atelier.Name = model.Name;
                atelier.priceRange = model.priceRange;
                atelier.Location = model.Location;
                atelier.ImageUrl = model.ImageUrl;

                atelierRepository.Update(atelier);
                atelierRepository.Save();

                TempData["SuccessMessage"] = "Atelier updated successfully!";
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing atelier ID {AtelierId}", model.Id);
                ModelState.AddModelError("", "An error occurred while updating the atelier.");
                return View("Edit", model);
            }
        }


    }
}
