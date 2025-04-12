using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;
using MVC_Projec2.ViewModels;

namespace MVC_Projec2.Controllers
{
    public class DecorController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IDecorRepository _decorRepository;
        private readonly IImageUploadService _imageUploadService;
        private readonly ILogger<DecorController> _logger;

        public DecorController(
            ICommentRepository commentRepository,
            IDecorRepository decorRepository,
            IImageUploadService imageUploadService,
            ILogger<DecorController> logger)
        {
            this._commentRepository = commentRepository;
            this._decorRepository = decorRepository;
            this._imageUploadService = imageUploadService;
            this._logger = logger;
        }

        public IActionResult GetAll()
        {

            try
            {
                return View(_decorRepository.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving decor items");
                return View(new List<Decor>());
            }
        }

        public IActionResult DecorDetails(int id)
        {
            var decor = _decorRepository.GetByIdWithImages(id);
            if (decor == null)
            {
                return NotFound();
            }

            var comments = _commentRepository.GetCommentsByService(id, ServiceType.Decor);

            var viewModel = new DecorCommentViewModel
            { 
                Decor = decor,
                Comments =  comments,
                CommentText = "" 
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddComment(DecorCommentViewModel model)
        {
            if (string.IsNullOrEmpty(model.CommentText))
            {
                ModelState.AddModelError("", "Please provide a comment.");
                return RedirectToAction("DecorDetails", new { id = model.Decor.Id });
            }

            var comment = new Comment
            {
                Content = model.CommentText,
                CreatedAt = DateTime.Now,
                ServiceType = ServiceType.MakeUp,
                UserId = User.Identity.Name,
                ServiceId = model.Decor.Id
            };

            _commentRepository.insert(comment);
            _commentRepository.Save();

            return RedirectToAction("DecorDetails", new { id = model.Decor.Id });
        }

        public IActionResult Search(string searchValue)
        {
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                return RedirectToAction("GetAll");
            }

            try
            {
                var decors = _decorRepository.SearchByName(searchValue);
                return View("GetAll", decors);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching Decors");
                TempData["ErrorMessage"] = "An error occurred during search";
                return RedirectToAction("GetAll");
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddDecor()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(AddDecorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var decor = new Decor
                {
                    Style = model.Style,
                    Price = model.Price,
                    Description = model.Description
                };

                
                foreach (var file in model.ImageFiles)
                {
                    var imageUrl = await _imageUploadService.UploadImageAsync(file);
                    decor.Images.Add(new DecoreImage { ImageUrl = imageUrl });
                }

                _decorRepository.insert(decor);
                _decorRepository.Save();

                TempData["SuccessMessage"] = $"Decor created with {model.ImageFiles.Count} images!";
                return RedirectToAction(nameof(GetAll));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding decor item");
                ModelState.AddModelError("", "Error creating decor. Please check image formats (JPG/PNG only)");
                return View(model);
            }
        }

        //[Authorize(Roles = "Admin")]
        [AllowAnonymous]
        public IActionResult Edit(int id)
        {
            var decor = _decorRepository.GetByIdWithImages(id);
            if (decor == null)
            {
                return NotFound();
            }

            var viewModel = new EditDecorViewModel
            {
                Images=decor.Images,
                Style = decor.Style,
                Price = decor.Price,
                Description = decor.Description,
                CurrentImageUrl= decor.ImageUrl,

            };

            return View(viewModel);
        }

        //[Authorize(Roles = "Admin")]
        [AllowAnonymous]
        public IActionResult SaveEdit(EditDecorViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}

            try
            {
                var decor = _decorRepository.GetById(model.Id);
                if (decor == null)
                {
                    return NotFound();
                }

               
                decor.Style = model.Style;
                decor.Price = model.Price;
                decor.Description = model.Description;
                decor.ImageUrl = model.CurrentImageUrl;

                _decorRepository.Update(decor);
                _decorRepository.Save();

                TempData["SuccessMessage"] = "Decor updated successfully (images not modified)";
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing decor ID {DecorId}", model.Id);
                ModelState.AddModelError("", "An error occurred while updating the decor.");
                return View(model);
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            try
            {
                var decor = _decorRepository.GetByIdWithImages(id);
                if (decor == null)
                {
                    return NotFound();
                }


                if (decor.Images != null && decor.Images.Count() > 0)
                {
                    foreach (var image in decor.Images)
                    {
                        _imageUploadService.DeleteImage(image.ImageUrl);
                    }

                }


                _decorRepository.Delete(decor);
                _decorRepository.Save();

                TempData["SuccessMessage"] = "Decor and all its images were deleted!";
                return RedirectToAction(nameof(GetAll));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting decor ID {DecorId}", id);
                TempData["ErrorMessage"] = "Error deleting decor. It may have associated bookings.";
                return RedirectToAction(nameof(GetAll));
            }
        }


    }
}
