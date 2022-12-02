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

            /*this.Pins.Add(new Pin(){Id = 10, Addres="al. Tysiąclecia 13" Name="Boisko SP nr 39", CoordLat=50.88842, CoordLon=20.65396});
            this.Pins.Add(new Pin(){Id = 11, Addres="Marszałkowska 96" Name="Boisko przy V LO", CoordLat=50.89091, CoordLon=20.64333});
            this.Pins.Add(new Pin(){Id = 11, Addres="Florentyny Malskiej 39" Name="Boisko Kampusu Politechniki", CoordLat=50.87947, CoordLon=20.64417});
            this.Pins.Add(new Pin(){Id = 11, Addres="Ignacego Daszyńskiego" Name="Boisko na Stoku", CoordLat=50.89149, CoordLon=20.66753});
            this.SaveChanges();*/
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Pin> Pins { get; set; }
    }
}