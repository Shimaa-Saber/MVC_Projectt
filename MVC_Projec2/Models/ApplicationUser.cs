using Microsoft.AspNetCore.Identity;

namespace MVC_Projec2.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}
