using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace MVC_Projec2.Models
{
    public class MVCProjectContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IConfiguration _configuration;

        public MVCProjectContext(DbContextOptions<MVCProjectContext> options,
                                 IConfiguration configuration): base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Atelier> Ateliers { get; set; }
        public DbSet<Decor> Decors { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<MakeUp_Service> MakeUpServices { get; set; }
        public DbSet<HallImage> HallImages { get; set; }
        public DbSet<DecoreImage> DecoreImages { get; set; }
        public DbSet<DecoreImage> AtelierImages { get; set; }
        public DbSet<DecoreImage> SessionImages { get; set; }
        public DbSet<DecoreImage> MakeUpImages { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }
            );

            var adminUserId = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = adminUserId,
                    UserName = "admin@example.com",
                    NormalizedUserName = "ADMIN@EXAMPLE.COM",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@1234!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "0123456789",
                    PhoneNumberConfirmed = true
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = adminUserId, RoleId = "1" }
            );


            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    Id = 3,
                    user_id = adminUserId,
                    MakeupId = 1,
                    Hall_Id = 2,
                    Session_Id = 2,
                    Decor_Id = 1,
                    Atelier_Id = 3,
                    Status = "Confirmed",
                    Created_at = DateTime.Now
                },
                new Booking
                {
                    Id = 4,
                    user_id = adminUserId,
                    MakeupId = 4,
                    Hall_Id = 1,
                    Session_Id = 1,
                    Decor_Id = 2,
                    Atelier_Id = 1,
                    Status = "Pending",
                    Created_at = DateTime.Today
                }

            );

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    UserId = adminUserId,
                    Content = "Excellent service!",
                    CreatedAt = DateTime.Now
                }

            );

            modelBuilder.Entity<Atelier>().HasData(
                new Atelier { Id = 1, Name = "Elite Atelier", Location = "Downtown" },
                new Atelier { Id = 2, Name = "Royal Designs", Location = "Uptown" },
                new Atelier { Id = 3, Name = "Glamorous Styles", Location = "City Center" },
                new Atelier { Id = 4, Name = "Elegant Creations", Location = "Suburb" },
                new Atelier { Id = 5, Name = "Chic Styles", Location = "North Park" },
                new Atelier { Id = 6, Name = "Vintage Touch", Location = "South Side" },
                new Atelier { Id = 7, Name = "Modern Artistry", Location = "Midtown" },
                new Atelier { Id = 8, Name = "Exquisite Design", Location = "East End" },
                new Atelier { Id = 9, Name = "Timeless Beauty", Location = "West End" },
                new Atelier { Id = 10, Name = "Fashion Forward", Location = "Central Square" }
            );

            modelBuilder.Entity<AtelierImages>().HasData(
                new AtelierImages { Id = 1, AtelierId = 1, ImageUrl = "atelier1.jpg" },
                new AtelierImages { Id = 2, AtelierId = 2, ImageUrl = "atelier2.jpg" },
                new AtelierImages { Id = 3, AtelierId = 3, ImageUrl = "atelier3.jpg" },
                new AtelierImages { Id = 4, AtelierId = 4, ImageUrl = "atelier4.jpg" },
                new AtelierImages { Id = 5, AtelierId = 5, ImageUrl = "atelier5.jpg" },
                new AtelierImages { Id = 6, AtelierId = 6, ImageUrl = "atelier6.jpg" },
                new AtelierImages { Id = 7, AtelierId = 7, ImageUrl = "atelier7.jpg" },
                new AtelierImages { Id = 8, AtelierId = 8, ImageUrl = "atelier8.jpg" },
                new AtelierImages { Id = 9, AtelierId = 9, ImageUrl = "atelier9.jpg" },
                new AtelierImages { Id = 10, AtelierId = 10, ImageUrl = "atelier10.jpg" }
            );

            modelBuilder.Entity<Hall>().HasData(
                new Hall { Id = 1, Name = "Grand Hall", Capacity = 500 },
                new Hall { Id = 2, Name = "Crystal Ballroom", Capacity = 300 },
                new Hall { Id = 3, Name = "Sunset Venue", Capacity = 200},
                new Hall { Id = 4, Name = "Majestic Hall", Capacity = 400 },
                new Hall { Id = 5, Name = "Ocean View", Capacity = 350},
                new Hall { Id = 6, Name = "Skyline Pavilion", Capacity = 600 },
                new Hall { Id = 7, Name = "Moonlight Hall", Capacity = 250},
                new Hall { Id = 8, Name = "Royal Suite", Capacity = 450},
                new Hall { Id = 9, Name = "Elite Venue", Capacity = 500},
                new Hall { Id = 10, Name = "Luxury Retreat", Capacity = 700}
            );

            modelBuilder.Entity<HallImage>().HasData(
                new HallImage { Id = 1, HallId = 1, ImageUrl = "hall1.jpg" },
                new HallImage { Id = 2, HallId = 2, ImageUrl = "hall2.jpg" },
                new HallImage { Id = 3, HallId = 3, ImageUrl = "hall3.jpg" },
                new HallImage { Id = 4, HallId = 4, ImageUrl = "hall4.jpg" },
                new HallImage { Id = 5, HallId = 5, ImageUrl = "hall5.jpg" },
                new HallImage { Id = 6, HallId = 6, ImageUrl = "hall6.jpg" },
                new HallImage { Id = 7, HallId = 7, ImageUrl = "hall7.jpg" },
                new HallImage { Id = 8, HallId = 8, ImageUrl = "hall8.jpg" },
                new HallImage { Id = 9, HallId = 9, ImageUrl = "hall9.jpg" },
                new HallImage { Id = 10, HallId = 10, ImageUrl = "hall10.jpg" }
            );

            modelBuilder.Entity<MakeUp_Service>().HasData(
                new MakeUp_Service { Id = 1, Name = "Bridal Makeup", Price = 1500 },
                new MakeUp_Service { Id = 2, Name = "Party Glam", Price = 800 },
                new MakeUp_Service { Id = 3, Name = "Natural Look", Price = 500 },
                new MakeUp_Service { Id = 4, Name = "Evening Elegance", Price = 1000 },
                new MakeUp_Service { Id = 5, Name = "Glamour Shine", Price = 1200 },
                new MakeUp_Service { Id = 6, Name = "Festival Glam", Price = 700 },
                new MakeUp_Service { Id = 7, Name = "Bridal Glow", Price = 1600 },
                new MakeUp_Service { Id = 8, Name = "Special Occasion", Price = 1300 },
                new MakeUp_Service { Id = 9, Name = "Celebrity Look", Price = 2000 },
                new MakeUp_Service { Id = 10, Name = "Simple Elegance", Price = 600 }
            );

            modelBuilder.Entity<MakeUpImages>().HasData(
                new MakeUpImages { Id = 1, MakeUpId = 1, ImageUrl = "makeUp1.jpg" },
                new MakeUpImages { Id = 2, MakeUpId = 2, ImageUrl = "makeUp2.jpg" },
                new MakeUpImages { Id = 3, MakeUpId = 3, ImageUrl = "makeUp3.jpg" },
                new MakeUpImages { Id = 4, MakeUpId = 4, ImageUrl = "makeUp4.jpg" },
                new MakeUpImages { Id = 5, MakeUpId = 5, ImageUrl = "makeUp5.jpg" },
                new MakeUpImages { Id = 6, MakeUpId = 6, ImageUrl = "makeUp6.jpg" },
                new MakeUpImages { Id = 7, MakeUpId = 7, ImageUrl = "makeUp7.jpg" },
                new MakeUpImages { Id = 8, MakeUpId = 8, ImageUrl = "makeUp8.jpg" },
                new MakeUpImages { Id = 9, MakeUpId = 9, ImageUrl = "makeUp9.jpg" },
                new MakeUpImages { Id = 10, MakeUpId = 10, ImageUrl = "makeUp10.jpg" }
            );

            modelBuilder.Entity<Decor>().HasData(
                new Decor { Id = 1, Style = "Classic", Price = 5000 },
                new Decor { Id = 2, Style = "Modern", Price = 7000 },
                new Decor { Id = 3, Style = "Rustic", Price = 4500 },
                new Decor { Id = 4, Style = "Vintage", Price = 5500 },
                new Decor { Id = 5, Style = "Industrial", Price = 6000 },
                new Decor { Id = 6, Style = "Boho", Price = 4000 },
                new Decor { Id = 7, Style = "Minimalist", Price = 6500 },
                new Decor { Id = 8, Style = "Art Deco", Price = 7000 },
                new Decor { Id = 9, Style = "Glam", Price = 8000 },
                new Decor { Id = 10, Style = "Shabby Chic", Price = 4500 }
            );

            modelBuilder.Entity<DecoreImage>().HasData(
                new DecoreImage { Id = 1, DecorId = 1, ImageUrl = "decor1.jpg" },
                new DecoreImage { Id = 2, DecorId = 2, ImageUrl = "decor2.jpg" },
                new DecoreImage { Id = 3, DecorId = 3, ImageUrl = "decor3.jpg" },
                new DecoreImage { Id = 4, DecorId = 4, ImageUrl = "decor4.jpg" },
                new DecoreImage { Id = 5, DecorId = 5, ImageUrl = "decor5.jpg" },
                new DecoreImage { Id = 6, DecorId = 6, ImageUrl = "decor6.jpg" },
                new DecoreImage { Id = 7, DecorId = 7, ImageUrl = "decor7.jpg" },
                new DecoreImage { Id = 8, DecorId = 8, ImageUrl = "decor8.jpg" }
                );

            modelBuilder.Entity<Session>().HasData(
               new Session { Id = 1, Type = "Photography", Duration = 2},
               new Session { Id = 2, Type = "Videography", Duration = 3},
               new Session { Id = 3, Type = "Engagement Shoot", Duration = 4},
               new Session { Id = 4, Type = "Pre-Wedding Shoot", Duration = 5},
               new Session { Id = 5, Type = "Wedding Photography", Duration = 6},
               new Session { Id = 6, Type = "Couple Shoot", Duration = 2},
               new Session { Id = 7, Type = "Bridal Portraits", Duration = 3},
               new Session { Id = 8, Type = "Fashion Photography", Duration = 4},
               new Session { Id = 9, Type = "Event Coverage", Duration = 5},
               new Session { Id = 10, Type = "Family Shoot", Duration = 3}
            );

            modelBuilder.Entity<SessionImages>().HasData(
                new SessionImages { Id = 1, SessionId = 1, ImageUrl = "session1.jpg" },
                new SessionImages { Id = 2, SessionId = 2, ImageUrl = "session2.jpg" },
                new SessionImages { Id = 3, SessionId = 3, ImageUrl = "session3.jpg" },
                new SessionImages { Id = 4, SessionId = 4, ImageUrl = "session4.jpg" },
                new SessionImages { Id = 5, SessionId = 5, ImageUrl = "session5.jpg" },
                new SessionImages { Id = 6, SessionId = 6, ImageUrl = "session6.jpg" },
                new SessionImages { Id = 7, SessionId = 7, ImageUrl = "session7.jpg" },
                new SessionImages { Id = 8, SessionId = 8, ImageUrl = "session8.jpg" },
                new SessionImages { Id = 9, SessionId = 9, ImageUrl = "session9.jpg" },
                new SessionImages { Id = 10, SessionId = 10, ImageUrl = "session10.jpg" }
            );

        }
    }
}
