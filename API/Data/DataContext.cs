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
        public DbSet<Pitch> Pitch { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}