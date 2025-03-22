using System;
using Microsoft.AspNetCore.Hosting; // Add this line for web hosting
using Microsoft.Extensions.Hosting; // Add this line for hosting extensions
using Microsoft.EntityFrameworkCore; // Add this line
using InventoryApp.Controllers;
using InventoryApp.Data; // Add this line

namespace InventoryApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build(); // Build the web host
            host.Run(); // Run the web host
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); // Use Startup class for configuration
                });
    }
}
