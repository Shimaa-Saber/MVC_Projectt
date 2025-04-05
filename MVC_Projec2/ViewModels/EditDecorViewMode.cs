using MVC_Projec2.Custom_Validation;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class EditDecorViewMode
    {
        public int Id { get; set; }

        [Required]
        public string Style { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Price { get; set; }

        public string Description { get; set; }

        public string CurrentImageUrl { get; set; }

        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
       
        public IFormFile NewImageFile { get; set; }
    }
}
