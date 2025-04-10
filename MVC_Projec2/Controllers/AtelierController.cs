using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;
using MVC_Projec2.ViewModel;

namespace MVC_Projec2.Controllers
{
    public class AtelierController : Controller
    {
        IAtelierRepository atelierRepository;
        IAtelierService _atelierService;
        public AtelierController( IAtelierRepository atelier, IAtelierService atelierService)
        {
           atelierRepository = atelier;
           _atelierService = atelierService;
        }

        public IActionResult GetAll(string? search)
        {
            List<Atelier> ateliersList = atelierRepository.GetAll();
            return View("Index", ateliersList);
        }

        public IActionResult Detail(int id)
        {
            Atelier atelier = atelierRepository.GetById(id);
            if (atelier == null)
            {
                return NotFound();
            }
            return View("Details", atelier);

        }
        [Authorize(Roles = "Admin")]
        public IActionResult New()
        {
            ViewData["AtelierList"] = atelierRepository.GetAll();
            return View();
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SaveNew(Atelier atelier, IFormFile ImageURL)
        {
            if (ModelState.IsValid == true)
            {

                if (ImageURL != null && ImageURL.Length > 0)
                {

                    var fileName = Path.GetFileName(ImageURL.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);


                    if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images")))
                    {
                        Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images"));
                    }


                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await ImageURL.CopyToAsync(stream);
                    }


                    atelier.ImageURL = "/images/" + fileName;
                }
                else
                {

                    ViewBag.Message = "plz upload image";
                }

                atelierRepository.insert(atelier);
                atelierRepository.Save();
                return RedirectToAction("Index");
            }
            ViewData["AtelierList"] = atelierRepository.GetAll();
            return View("New", atelier);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id) 
        {
            Atelier atelier = atelierRepository.GetById(id);
            if(atelier == null)
            {
                return NotFound();
            }
            EditViewModel model = new EditViewModel();
            model.Id = atelier.Id;
            model.Name = atelier.Name;
            model.ImageURL = atelier.ImageURL;
            model.Location = atelier.Location;
            return View("Edit" , model);

        }
        [Authorize(Roles = "Admin")]
        public ActionResult SaveEdit( EditViewModel AtelierFromRequest)
        {
            if (AtelierFromRequest.Name != null)
            {
                Atelier atelierFromDB = atelierRepository.GetById(AtelierFromRequest.Id);
                atelierFromDB.Id = AtelierFromRequest.Id;
                atelierFromDB.Name = AtelierFromRequest.Name;
                atelierFromDB.Location = AtelierFromRequest.Location;
                atelierFromDB.ImageURL = AtelierFromRequest.ImageURL;
                atelierRepository.Save();
               return  RedirectToAction("Index");
            }
            
            return View("Edit", AtelierFromRequest);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            Atelier atelier = atelierRepository.GetById(id);
            return View(atelier);
        }
       

 

    
    
    
    
    
    
    
    
    
    
    
    
    }
}
