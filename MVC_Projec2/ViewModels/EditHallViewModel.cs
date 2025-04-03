using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class EditHallViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 1000)]
        public int Capacity { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [Range(0.1, double.MaxValue)]
        public double Price { get; set; }
    }
}
