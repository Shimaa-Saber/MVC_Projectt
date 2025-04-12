using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;
using MVC_Projec2.ViewModels;
using System;

namespace MVC_Projec2.Controllers
{
    public class MakeUpController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMakeUpRepository _makeUpRepository;
        private readonly IImageUploadService _imageUploadService;
        private readonly ILogger<SessionController> _logger;

        public MakeUpController(
            ICommentRepository commentRepository,
            IMakeUpRepository makeUpRepository,
            IImageUploadService imageUploadService,
            ILogger<SessionController> logger)
        {
            this._makeUpRepository = makeUpRepository;
            this._imageUploadService = imageUploadService;
            this._logger = logger;
        }

        public IActionResult GetAll()
        {
            try
            {
                return View(_makeUpRepository.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving MakeUp_Service items");
                return View(new List<MakeUp_Service>());
            }
        }

        public IActionResult Details(int id)
        {
            var makeUp = _makeUpRepository.GetById(id);
            if (makeUp == null)
            {
                return NotFound();
            }

            var comments = _commentRepository.GetCommentsByService(id, ServiceType.MakeUp);

            var viewModel = new MakeUpCommentViewModel
            {
                makeUp = makeUp,
                Comments = comments,
                CommentText = ""
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(MakeUpCommentViewModel model)
        {
            if (string.IsNullOrEmpty(model.CommentText))
            {
                ModelState.AddModelError("", "Please provide a comment.");
                return RedirectToAction("Details", new { id = model.makeUp.Id });
            }

            try
            {
                var newComment = new Comment
                {
                    Content = model.CommentText,
                    CreatedAt = DateTime.Now,
                    ServiceType = ServiceType.MakeUp,
                    UserId = User.Identity.Name,
                    ServiceId= model.makeUp.Id
                };
                _commentRepository.insert(newComment);
                _commentRepository.Save();

                TempData["SuccessMessage"] = "Comment added successfully!";
                return RedirectToAction("Details", new { id = model.makeUp.Id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding comment for MakeUp Service ID {MakeUpId}", model.makeUp.Id);
                ModelState.AddModelError("", "Error adding comment.");
                return RedirectToAction("Details", new { id = model.makeUp.Id });
            }
        }

        public IActionResult Search(string searchValue)
        {
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                return RedirectToAction("GetAll");
            }

            try
            {
                var makeUp_s = _makeUpRepository.SearchByName(searchValue);
                return View("GetAll", makeUp_s);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching Makeup");
                TempData["ErrorMessage"] = "An error occurred during search";
                return RedirectToAction("GetAll");
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddSession()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(AddMakeUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var makeUp = new MakeUp_Service
                {
                    Name = model.Name,
                    Price = model.Price
                };

                foreach (var file in model.ImageFiles)
                {
                    var imageUrl = await _imageUploadService.UploadImageAsync(file);
                    makeUp.Images.Add(new MakeUpImages { ImageUrl = imageUrl });
                }

                _makeUpRepository.insert(makeUp);
                _makeUpRepository.Save();

                TempData["SuccessMessage"] = "MakeUp Service created successfully!";
                return RedirectToAction(nameof(GetAll));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding MakeUp");
                ModelState.AddModelError("", "Error creating MakeUp. Please check the image format (JPG/PNG only)");
                return View(model);
            }
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            var makeUp = _makeUpRepository.GetById(id);
            if (makeUp == null)
            {
                return NotFound();
            }

            var viewModel = new EditMakeUpViewModel
            {
                Id = makeUp.Id,
                Name = makeUp.Name,
                Price = makeUp.Price,
                ImageUrl = makeUp.ImageUrl,
            };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(EditMakeUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var makeUp = _makeUpRepository.GetById(model.Id);
                if (makeUp == null)
                {
                    return NotFound();
                }

                makeUp.Name = model.Name;
                makeUp.Price = model.Price;
                makeUp.ImageUrl = model.ImageUrl;

                _makeUpRepository.Update(makeUp);
                _makeUpRepository.Save();

                TempData["SuccessMessage"] = "MakeUp_Service updated successfully!";
                return RedirectToAction(nameof(GetAll));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating MakeUp_Service");
                ModelState.AddModelError("", "Error updating MakeUp_Service. Please try again.");
                return View(model);
            }
        }

      //  [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            try
            {
                var makeUp = _makeUpRepository.GetById(id);
                if (makeUp == null)
                {
                    return NotFound();
                }

                if (makeUp.Images != null && makeUp.Images.Count() > 0)
                {
                    foreach (var image in makeUp.Images)
                    {
                        _imageUploadService.DeleteImage(image.ImageUrl);
                    }

                }


                _makeUpRepository.Delete(makeUp);
                _makeUpRepository.Save();

                TempData["SuccessMessage"] = "MakeUp_Service and its image were deleted successfully!";
                return RedirectToAction("GetAllMackeups", "Dashboard");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting MakeUp_Service ID {SessionId}", id);

                TempData["ErrorMessage"] = "Error deleting MakeUp_Service. Please try again.";
                return RedirectToAction("GetAllMackeups", "Dashboard");
            }
        }
    }
}
