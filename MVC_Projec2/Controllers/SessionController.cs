using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;
using MVC_Projec2.ViewModels;

namespace MVC_Projec2.Controllers
{
    public class SessionController : Controller
    {

        private readonly ISessionRepository _sessionRepository;
        private readonly IImageUploadService _imageUploadService;
        private readonly ILogger<SessionController> _logger;


        public SessionController(
            ISessionRepository sessionRepository,
            IImageUploadService imageUploadService,
            ILogger<SessionController> logger)
        {
            this._sessionRepository = sessionRepository;
            this._imageUploadService = imageUploadService;
            this._logger = logger;
        }

        public IActionResult GetAll()
        {
            try
            {
                var sessionList = _sessionRepository.GetAll();
                return View("GetAll", sessionList);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving session items");
                return View(new List<Session>());
            }
        }

        public IActionResult Details(int id)
        {
            var session = _sessionRepository.GetById(id);
            if (session == null)
            {
                return NotFound();
            }
            return View(session);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult AddSession()
        {
            return View();
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(AddSessionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var imageUrl = await _imageUploadService.UploadImageAsync(model.ImageFile);

                var session = new Session
                {
                    Type = model.Type,
                    Duration = model.Duration,
                    ImageUrl = imageUrl
                };

                _sessionRepository.insert(session); 
                _sessionRepository.Save();

                TempData["SuccessMessage"] = "Session created successfully!";
                return RedirectToAction(nameof(GetAll));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding session");
                ModelState.AddModelError("", "Error creating session. Please check the image format (JPG/PNG only)");
                return View(model);
            }
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            var session = _sessionRepository.GetById(id);
            if (session == null)
            {
                return NotFound();
            }

            var viewModel = new EditSessionViewModel
            {
                Id = session.Id,
                Type = session.Type,
                Duration = session.Duration,
                ImageUrl = session.ImageUrl,  
            };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(EditSessionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var session = _sessionRepository.GetById(model.Id);
                if (session == null)
                {
                    return NotFound();
                }

                session.Type = model.Type;
                session.Duration = model.Duration;

                if (model.ImageFile != null)
                {
                    var imageUrl = await _imageUploadService.UploadImageAsync(model.ImageFile);
                    session.ImageUrl = imageUrl;  
                }

                _sessionRepository.Update(session);
                _sessionRepository.Save();

                TempData["SuccessMessage"] = "Session updated successfully!";
                return RedirectToAction(nameof(GetAll));  
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating session");
                ModelState.AddModelError("", "Error updating session. Please try again.");
                return View(model);
            }
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            try
            {
                var session = _sessionRepository.GetById(id);
                if (session == null)
                {
                    return NotFound();
                }

                if (!string.IsNullOrEmpty(session.ImageUrl))
                {
                    _imageUploadService.DeleteImage(session.ImageUrl);
                }

                _sessionRepository.Delete(session);
                _sessionRepository.Save();

                TempData["SuccessMessage"] = "Session and its image were deleted successfully!";
                return RedirectToAction(nameof(GetAll));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting session ID {SessionId}", id);

                TempData["ErrorMessage"] = "Error deleting session. Please try again.";
                return RedirectToAction(nameof(GetAll)); 
            }
        }


    }
}
