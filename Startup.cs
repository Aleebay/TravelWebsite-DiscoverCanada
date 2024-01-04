using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Project13
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method is used to configure the services required by the application.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add MVC services to the Application.
            services.AddControllersWithViews();
        }

        // This method is used to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // Display detailed error information when in Development mode.
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Use a generic error page when not in development mode.
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            // Redirect HTTP requests to HTTPS.
            app.UseHttpsRedirection();

            // Serve Static files [e.g., HTML, CSS, JavaScript].
            app.UseStaticFiles();

            // Enable Routing.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "destination",
                    pattern: "Home/Destination",
                    defaults: new { controller = "Home", action = "Destination" });

                endpoints.MapControllerRoute(
                    name: "deatinationDetails",
                    pattern: "Home/DestinationDetails",
                    defaults: new { controller = "Home", action = "DestinationDetails" });

                endpoints.MapControllerRoute(
                    name: "accommodation",
                    pattern: "Home/Accommodation",
                    defaults: new { controller = "Home", action = "Accommodation" });

                endpoints.MapControllerRoute(
                    name: "booking",
                    pattern: "Home/Booking",
                    defaults: new { controller = "Home", action = "Booking" });

                endpoints.MapControllerRoute(
                    name: "cuisine",
                    pattern: "Home/Cuisine",
                    defaults: new { controller = "Home", action = "Cuisine" });

                endpoints.MapControllerRoute(
                    name: "restaurantRecomendation",
                    pattern: "Home/RestaurantRecomendation",
                    defaults: new { controller = "Home", action = "RestaurantRecomendation" });

                endpoints.MapControllerRoute(
                    name: "contact_us",
                    pattern: "Home/Contact_Us",
                    defaults: new { controller = "Home", action = "Contact_Us" });


                endpoints.MapControllerRoute(
                    name: "privacy",
                    pattern: "Home/Privacy",
                    defaults: new { controller = "Home", action = "Privacy" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}


