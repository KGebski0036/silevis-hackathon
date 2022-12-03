using System.Security.Cryptography;
using System.Text;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            // this.Pitches.Add(new Pitch(){ Name = "Orlik przy SP 27", Address="Marszałkowska 96 Kielce", Description="Boisko jest oświetlone", CoordLat=50.89088, CoordLon=20.64342});
            // this.Pitches.Add(new Pitch(){ Name = "Boisko przy Klonowej", Address="Klonowa 52 Kielce", Description="Sztuczna nawierzchnia", CoordLat=50.89274, CoordLon=20.64126});
            // this.Pitches.Add(new Pitch(){ Name = "Boisko na Jezioranskiego", Address="Jana Nowaka-Jeziorańskiego 53, 25-432 Kielce", Description="Duże oświetlone boisko", CoordLat=50.89028, CoordLon=20.65906});
            // this.Pitches.Add(new Pitch(){ Name = "Boiska na Zamenhofa", Address="Ludwika Zamenhofa 5, 25-555 Kielce", Description="Małe zaniedbane betonowe boisko", CoordLat=50.88785, CoordLon=20.63842});
            // this.Pitches.Add(new Pitch(){ Name = "Boisko trawiaste", Address="W. Przyborowskiego 78, 25-414 Kielce", Description="Czterokanciaste", CoordLat=50.89292, CoordLon=20.65630});
            // this.Pitches.Add(new Pitch(){ Name = "Pol boiska na stoko", Address="Osiedle na Stoku 83, 25-414 Kielce", Description="A gdzie drugie pół? wtf", CoordLat=50.89387, CoordLon=20.65750});
            // this.Pitches.Add(new Pitch(){ Name = "Boisko treningowe MOSiR", Address="Janusza Kusocińskiego 53, 25-960 Kielce", Description="duże boisko z trybunami", CoordLat=50.85685, CoordLon=20.60143});


            // using var hmac = new HMACSHA512();

            // this.Users.Add(new AppUser{ UserName = "Roberto", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska"});
            // this.Users.Add(new AppUser{ UserName = "Kamil Messi", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska",});
            // this.Users.Add(new AppUser{ UserName = "Mateusz piniążek", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska",});
            // this.Users.Add(new AppUser{ UserName = "Krychowiak", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska",});
            // this.Users.Add(new AppUser{ UserName = "Piątek", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska",});
            // this.Users.Add(new AppUser{ UserName = "Nieszczęsny", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska",});
            // this.Users.Add(new AppUser{ UserName = "Ludwik", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska",});
            // this.Users.Add(new AppUser{ UserName = "Jaca praca", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska",});
            // this.Users.Add(new AppUser{ UserName = "K Ivon", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska", Country="Germany"});
            // this.Users.Add(new AppUser{ UserName = "Serru", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska",});
            // this.Users.Add(new AppUser{ UserName = "Gakiga", PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("aaaa")), PasswordSalt = hmac.Key, DateOfBirth = new DateOnly(2000,12,09), Gender="Men", Nickname="Gigachad boiska",});


            // this.SaveChanges();

            // this.Events.Add(new Event(){PitchId = 1, MaxPlayers = 25, Description = "Gramy twardo (:-:)", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});
            // this.Events.Add(new Event(){  PitchId = 1, MaxPlayers = 10, Description = "Grają tylko studenci", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});
            // this.Events.Add(new Event(){  PitchId = 2, MaxPlayers = 25, Description = "Gramy twardo (:-:)", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});
            // this.Events.Add(new Event(){  PitchId = 4, MaxPlayers = 25, Description = "Marcinkowe granie", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});
            // this.Events.Add(new Event(){  PitchId = 2, MaxPlayers = 10, Description = "Grają tylko studenci", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});
            // this.Events.Add(new Event(){  PitchId = 2, MaxPlayers = 15, Description = "Grają tylko studenci", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});
            // this.Events.Add(new Event(){  PitchId = 2, MaxPlayers = 25, Description = "Gramy twardo (:-:)", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});
            // this.Events.Add(new Event(){  PitchId = 2, MaxPlayers = 15, Description = "Tylko dla dziewczyn", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});
            // this.Events.Add(new Event(){ PitchId = 4, MaxPlayers = 25, Description = "Gramy twardo (:-:)", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});
            // this.Events.Add(new Event(){PitchId = 2, MaxPlayers = 35, Description = "Zapraszamy wszystkich", DateFrom = new DateTime(2022,12,09,09,15,00), DateTo = new DateTime(2022,12,10,09,15,00)});



            
                
            // this.SaveChanges();

        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Pitch> Pitches { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}