using GpsTrackingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GpsTrackingApp
{
    public static class CustomConfiguration
    {
        #region Builder
        public static WebApplicationBuilder AddCustomBuilderConfiguration(this WebApplicationBuilder builder)
        {
            // Data Context
            builder.Services.AddDbContext<AppDbContext>(conf =>
            {
                conf.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddHttpContextAccessor();

            // Hot reload for Razor Pages (if applicable)
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            // Add additional services as needed
            AddServices(builder);

            return builder;
        }

        private static void AddServices(WebApplicationBuilder builder)
        {
            // Add any scoped, transient, or singleton services here
            // Example:
            // builder.Services.AddScoped<IMyService, MyService>();

            // For demonstration, I'll add a dummy service
            builder.Services.AddScoped<IDummyService, DummyService>();
        }

        #endregion

        #region App

        public static WebApplication AddCustomConfiguration(this WebApplication app)
        {
            // Add middleware, seed data, etc.
            SeedData(app);

            return app;
        }

        private static void SeedData(WebApplication app)
        {
            // Seed initial data if necessary
            using (var scope = app.Services.CreateScope())
            {
                var dbInitializer = scope.ServiceProvider.GetRequiredService<DbInitializer>();
                dbInitializer.Seed();
            }
        }

        #endregion
    }

    public interface IDummyService
    {
        // Define service methods
    }

    public class DummyService : IDummyService
    {
        // Implement service methods
    }

    public class DbInitializer
    {
        public void Seed()
        {
            // Seed initial data
        }
    }
}

