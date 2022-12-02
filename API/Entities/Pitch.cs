namespace API.Entities
{
    public class Pitch
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Adress { get; set; }
        public int CoordLat { get; set; }
        public int CoordLon { get; set; }
        public int MaxPlayers { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
