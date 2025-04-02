using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.Models
{
    public class Atelier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }
}
