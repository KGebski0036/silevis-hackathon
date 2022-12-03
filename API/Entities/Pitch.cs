using System.Text.Json.Serialization;

namespace API.Entities
{
    public class Pitch
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Address { get; set; }
        public string Description { get; set; }
        public double CoordLat { get; set; }
        public double CoordLon { get; set; }
        
        [JsonIgnore]
        public List<Event> Events { get; set; } = new List<Event>();
        public Photo Photo { get; set; }
    }
}
