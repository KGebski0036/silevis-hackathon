using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            // this.Pins.Add(new Pin(){Id = 4, Name="a", CoordLat=1, CoordLon=2});
            // this.SaveChanges();
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Pin> Pins { get; set; }
    }
}