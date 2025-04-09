using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MVC_Projec2.Hubs;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;



namespace MVC_Projec2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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
            ); 


            builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()  
                            .AddEntityFrameworkStores<MVCProjectContext>()
                            .AddDefaultTokenProviders();


            builder.Services.AddSignalR();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    await RoleInitializer.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapHub<CommentHub>("/commentHub");


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

           await app.RunAsync();
        }
    }
}
