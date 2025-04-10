﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.ViewModels;

namespace MVC_Projec2.Controllers
{
    //[Authorize(Roles = "Admin")]
    //[Route("admin/dashboard")]
    public class DashboardController : Controller
    {
        private readonly MVCProjectContext _context;
        private readonly ILogger<DashboardController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHallRepository _hallRepository;
        private readonly IDecorRepository _decorRepository;
        private readonly IMakeUpRepository _makeUpRepository;
        private readonly ISessionRepository _sessionRepository;

        public DashboardController(MVCProjectContext context, ILogger<DashboardController> logger,
            UserManager<ApplicationUser> userManager,
            IHallRepository hallRepository,
            IDecorRepository decorRepository,
            IMakeUpRepository makeUpRepository, 
            ISessionRepository sessionRepository
            )
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
            _hallRepository = hallRepository;
            _decorRepository = decorRepository;
            _makeUpRepository = makeUpRepository;
            _sessionRepository = sessionRepository;


        }

        public IActionResult Index()
        {
            try
            {
                var model = new DashboardViewModel
                {
                    TotalUsers = GetTotalUsers(),
                    TotalBookings = GetTotalBookings(),
                    //Revenue = GetTotalRevenue(),
                    MostBookedVenue = GetMostBookedVenue(),
                    RecentBookings = GetRecentBookings(5)
                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading dashboard statistics");
                TempData["ErrorMessage"] = "Could not load dashboard data";
                return View(new DashboardViewModel());
            }
        }

        private int GetTotalUsers()
        {
            return _context.Users.Count();
        }


        public async Task<IActionResult> AssignedToAdmin(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var result = await _userManager.AddToRoleAsync(user, "Admin");
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = $"{user.UserName} has been Assigned to Admin";
                return RedirectToAction("UserManagement");
            }

            TempData["ErrorMessage"] = $"Failed to Assign {user.UserName}";
            return RedirectToAction("UserManagement");
        }




        public async Task<IActionResult> UserManagement()
        {
            var users = await _context.Users.ToListAsync();
            var userRoles = new List<UserRoleViewModel>();

            foreach (var user in users)
            {
                var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
                userRoles.Add(new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    IsAdmin = isAdmin
                });
            }

            return View(userRoles);
        }


        private int GetTotalBookings()
        {
            return _context.Bookings.Count();
        }

       

        private string GetMostBookedVenue()
        {
            return _context.Bookings
                .GroupBy(b => b.Hall.Name)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault() ?? "No bookings yet";
        }

        private List<Booking> GetRecentBookings(int count)
        {
            return _context.Bookings
                .Include(b => b.Hall)
                .Include(b => b.user)
                .OrderByDescending(b => b.Created_at)
                .Take(count)
                .ToList();
        }


        public IActionResult GetAll()
        {
            List<Hall> HallList = _hallRepository.GetAll();

            return View("GetAll", HallList);
        }


        public IActionResult GetAllDecors()
        {
            try
            {
                var decorList = _decorRepository.GetAll();
                return View("GetAllDecors", decorList);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving decor items");
                return View(new List<Decor>());
            }
        }

        public IActionResult GetAllMackeups()
        {
            try
            {
                var makeUpList = _makeUpRepository.GetAll();
                return View("GetAllMackeups", makeUpList);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving MakeUp_Service items");
                return View(new List<MakeUp_Service>());
            }
        }

        public IActionResult GetAllSessions()
        {
            try
            {
                var sessionList = _sessionRepository.GetAll();
                return View("GetAllSessions", sessionList);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving session items");
                return View(new List<Session>());
            }
        }
    }
}
