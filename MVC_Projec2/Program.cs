using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;

namespace MVC_Projec2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IDecorRepository, DecorRepository>();
            builder.Services.AddScoped<IHallRepository, HallRepository>();
            builder.Services.AddScoped<IAtelierRepository, AtelierRepository>();
            builder.Services.AddScoped<IBookingReposirtory, BookingRepository>();
            builder.Services.AddScoped<IMakeUpRepository, MakeUpRepository>();
            builder.Services.AddScoped<ISessionRepository, SessionRepository>();
            builder.Services.AddScoped<ICommentRepository, CommentRepository>();
            builder.Services.AddScoped<IImageUploadService, ImageUploadServices>();




            builder.Services.AddDbContext<MVCProjectContext>(
               options => options.UseSqlServer(builder.Configuration.GetConnectionString("CS"))
               ); ;

          
    //        builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()  
    //.AddEntityFrameworkStores<MVCProjectContext>()
    //.AddDefaultTokenProviders();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
