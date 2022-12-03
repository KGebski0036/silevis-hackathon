using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

            if(!this.Pitches.Any()) {
                this.Pitches.Add(new Pitch(){Id = 10, Description = "Boisko posiada murawę" , Address="al. Tysiąclecia 13", Name="Boisko SP nr 39", CoordLat=50.88842, CoordLon=20.65396});
                this.Pitches.Add(new Pitch(){Id = 11, Description = "Boisko posiada murawę" , Address="Marszałkowska 96", Name="Boisko przy V LO", CoordLat=50.89091, CoordLon=20.64333});
                this.Pitches.Add(new Pitch(){Id = 12, Description = "Boisko posiada murawę" , Address="Florentyny Malskiej 39", Name="Boisko Kampusu Politechniki", CoordLat=50.87947, CoordLon=20.64417});
                this.Pitches.Add(new Pitch(){Id = 13, Description = "Boisko posiada murawę" , Address="Ignacego Daszyńskiego", Name="Boisko na Stoku", CoordLat=50.89149, CoordLon=20.66753});
            }

            


            this.SaveChanges();
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Pitch> Pitches { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}