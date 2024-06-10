using Microsoft.EntityFrameworkCore;

namespace GpsTrackingApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<GpsCoordinate> GpsCoordinates { get; set; }
    }
}

