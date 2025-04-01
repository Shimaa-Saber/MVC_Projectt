using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.Models
{
    public class User
    {
        [Key]
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password_hash { get; set; }
        public DateTime Created_at { get; set; }

    }
}
