﻿namespace API.Entities
{
    public class Pitch
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Adress { get; set; }
        public string Description { get; set; }
        public double CoordLat { get; set; }
        public double CoordLon { get; set; }
        public int MaxPlayers { get; set; }
        public List<Reservation> Reservations { get; set; }
        public Photo Photo { get; set; }
    }
}
