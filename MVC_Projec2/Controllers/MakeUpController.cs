using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;
using MVC_Projec2.ViewModels;

namespace MVC_Projec2.Controllers
{
    public class MakeUpController : Controller
    {
        private readonly IMakeUpRepository _makeUpRepository;
        private readonly IImageUploadService _imageUploadService;
        private readonly ILogger<SessionController> _logger;


        public MakeUpController(
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
                var makeUpList = _makeUpRepository.GetAll();
                return View("GetAll", makeUpList);
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
            return View(makeUp);
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
                var imageUrl = await _imageUploadService.UploadImageAsync(model.ImageFile);

                var makeUp = new MakeUp_Service
                {
                    Name = model.Name,
                    Price = model.Price,
                    ImageUrl = imageUrl
                };

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


                if (model.ImageFile != null)
                {
                    var imageUrl = await _imageUploadService.UploadImageAsync(model.ImageFile);
                    makeUp.ImageUrl = imageUrl;
                }

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


        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            try
            {
                var makeUp = _makeUpRepository.GetById(id);
                if (makeUp == null)
                {
                    return NotFound();
                }

                if (!string.IsNullOrEmpty(makeUp.ImageUrl))
                {
                    _imageUploadService.DeleteImage(makeUp.ImageUrl);
                }

                _makeUpRepository.Delete(makeUp);
                _makeUpRepository.Save();

                TempData["SuccessMessage"] = "MakeUp_Service and its image were deleted successfully!";
                return RedirectToAction(nameof(GetAll));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting MakeUp_Service ID {SessionId}", id);

                TempData["ErrorMessage"] = "Error deleting MakeUp_Service. Please try again.";
                return RedirectToAction(nameof(GetAll));
            }
        }

    }
}
