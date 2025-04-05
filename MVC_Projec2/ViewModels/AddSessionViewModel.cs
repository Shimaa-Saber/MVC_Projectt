using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class AddSessionViewModel
    {

        [Required(ErrorMessage = "Session type is required")]
        [StringLength(100, ErrorMessage = "Session type must not exceed 100 characters")]
        public string Type { get; set; }


        [Required(ErrorMessage = "Session duration is required")]
        [Range(1, 300, ErrorMessage = "Session duration must be between 1 and 300 minutes")]
        public int Duration { get; set; }


        [Required(ErrorMessage = "Session image is required")]
        public IFormFile ImageFile { get; set; }


    }
}
