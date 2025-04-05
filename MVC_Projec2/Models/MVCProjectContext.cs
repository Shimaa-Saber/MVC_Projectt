using Microsoft.EntityFrameworkCore;

namespace MVC_Projec2.Models
{
    public class MVCProjectContext:DbContext
    {
        private readonly IConfiguration _configuration;

        public MVCProjectContext(DbContextOptions<MVCProjectContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Atelier> Ateliers { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<MakeUp_Service> MakeUpServices { get; set; }
        public DbSet<Decor> Decors { get; set; }
        public DbSet<Session> Sessions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string? connectionString = _configuration.GetConnectionString("ConnectionStrings");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Hager", Email = "h@gmail.com", Phone = "01113986645", Password_hash = "h_123@20", Created_at = DateTime.Now },
                new User { Id = 2, Name = "Asmaa", Email = "a@gmail.com", Phone = "01213986647", Password_hash = "a@5002", Created_at = DateTime.Today },
                new User { Id = 3, Name = "Shimaa", Email = "s@gmail.com", Phone = "01013986647", Password_hash = "s123@4", Created_at = DateTime.Now },
                new User { Id = 4, Name = "Fatma", Email = "f@gmail.com", Phone = "01118936647", Password_hash = "f1@237", Created_at = DateTime.Today }
            );
            int adminUserId = 1;
            modelBuilder.Entity<Booking>().HasData(
            new Booking
            {
                Id = 1,
                User_Id= adminUserId,
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
                    Id = 2,
                    User_Id = adminUserId,
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
                new Comment { Id = 1, User_Id = 3, Content = "Excellent service!", Created_at = DateTime.Now, Hall_Id = 2, MakeupId = 1, Session_Id = 2, Decor_Id = 1, Atelier_Id = 3 },
                new Comment { Id = 2, User_Id = 1, Content = "Loved the decorations!", Created_at = DateTime.Now, Hall_Id = 2, MakeupId = 1, Session_Id = 2, Decor_Id = 1, Atelier_Id = 3 },
                new Comment { Id = 3, User_Id = 4, Content = "Great experience, highly recommend!", Created_at = DateTime.Now, Hall_Id = 2, MakeupId = 1, Session_Id = 2, Decor_Id = 1, Atelier_Id = 3 },
                new Comment { Id = 4, User_Id = 2, Content = "Nice ambiance but service could be better.", Created_at = DateTime.Now, Hall_Id = 2, MakeupId = 1, Session_Id = 2, Decor_Id = 1, Atelier_Id = 3 }
            );

            modelBuilder.Entity<Atelier>().HasData(
                new Atelier { Id = 1, Name = "Elite Atelier", Location = "Downtown" },
                new Atelier { Id = 2, Name = "Royal Designs", Location = "Uptown" },
                new Atelier { Id = 3, Name = "Glamorous Styles", Location = "City Center" },
                new Atelier { Id = 4, Name = "Elegant Creations", Location = "Suburb" }
            );

            modelBuilder.Entity<Hall>().HasData(
                new Hall { Id = 1, Name = "Grand Hall", Capacity = 500, ImageUrl = "1.jpg" },
                new Hall { Id = 2, Name = "Crystal Ballroom", Capacity = 300, ImageUrl = "3.jpg" },
                new Hall { Id = 3, Name = "Sunset Venue", Capacity = 200, ImageUrl = "5.jpg" }
            );

            modelBuilder.Entity<MakeUp_Service>().HasData(
                new MakeUp_Service { Id = 1, Name = "Bridal Makeup", Price = 1500 },
                new MakeUp_Service { Id = 2, Name = "Party Glam", Price = 800 },
                new MakeUp_Service { Id = 3, Name = "Natural Look", Price = 500 },
                new MakeUp_Service { Id = 4, Name = "Evening Elegance", Price = 1000 }
            );

            modelBuilder.Entity<Decor>().HasData(
                new Decor { Id = 1, Style = "Classic", Price = 5000 },
                new Decor { Id = 2, Style = "Modern", Price = 7000 },
                new Decor { Id = 3, Style = "Rustic", Price = 4500 }
            );

            modelBuilder.Entity<Session>().HasData(
                new Session { Id = 1, Type = "Photography", Duration = 2, ImageUrl="1.jpg"},
                new Session { Id = 2, Type = "Videography", Duration = 3, ImageUrl = "2.jpg" },
                new Session { Id = 3, Type = "Engagement Shoot", Duration = 4, ImageUrl = "3.jpg" },
                new Session { Id = 4, Type = "Pre-Wedding Shoot", Duration = 5, ImageUrl = "4.jpg" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
