using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;
using MVC_Projec2.ViewModels;
using System;

namespace MVC_Projec2.Controllers
{
    public class SessionController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly ISessionRepository _sessionRepository;
        private readonly IImageUploadService _imageUploadService;
        private readonly ILogger<SessionController> _logger;

        public SessionController(
               ICommentRepository commentRepository,
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
                return View(_sessionRepository.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving session items");
                return View(new List<Session>());
            }
        }

        public IActionResult Details(int id)
        {
            var session = _sessionRepository.GetByIdWithImages(id);
            if (session == null)
            {
                return NotFound();
            }

            var comments = _commentRepository.GetCommentsByService(id, ServiceType.Session);

            var viewModel = new SessionCommentViewModel
            {
                Session = session,
                Comments = comments,
                CommentText = ""
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddComment(SessionCommentViewModel model)
        {
            if (string.IsNullOrEmpty(model.CommentText))
            {
                ModelState.AddModelError("", "Please provide a comment.");
                return RedirectToAction("Details", new { id = model.Session.Id });
            }

            var comment = new Comment
            {
                Content = model.CommentText,
                CreatedAt = DateTime.Now,
                ServiceType = ServiceType.MakeUp,
                UserId = User.Identity.Name,
                ServiceId = model.Session.Id
            };

            _commentRepository.insert(comment);
            _commentRepository.Save();

            return RedirectToAction("Details", new { id = model.Session.Id });
        }

        public IActionResult Search(string searchValue)
        {
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                return RedirectToAction("GetAll");
            }

            try
            {
                var sessions = _sessionRepository.SearchByName(searchValue);
                return View("GetAll", sessions);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching Sessions");
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
        public async Task<IActionResult> Create(AddSessionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var session = new Session
                {
                    Type = model.Type,
                    Duration = model.Duration
                };

                foreach (var file in model.ImageFiles)
                {
                    var imageUrl = await _imageUploadService.UploadImageAsync(file);
                    session.Images.Add(new SessionImages { ImageUrl = imageUrl });
                }

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
            var session = _sessionRepository.GetByIdWithImages(id);
            if (session == null)
            {
                return NotFound();
            }

            var viewModel = new EditSessionViewModel
            {
                Images= session.Images,
                Type = session.Type,
                Duration = session.Duration
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

                if (session.Images != null && session.Images.Count()>0)
                {
                    foreach(var image in session.Images)
                    {
                     _imageUploadService.DeleteImage(image.ImageUrl);
                    }
                    
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
