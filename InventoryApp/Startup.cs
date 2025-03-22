using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using InventoryApp.Data;

namespace InventoryApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=inventory.db")); // Configure SQLite database
            services.AddControllers(); // Add MVC services
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Use developer exception page in development
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); // Use error handling in production
                app.UseHsts(); // Use HSTS in production
            }

            app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
            app.UseRouting(); // Enable routing

            app.UseAuthorization(); // Enable authorization

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Map attribute-routed controllers
            });
        }
    }
}
