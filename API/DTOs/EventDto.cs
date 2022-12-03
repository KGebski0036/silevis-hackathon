using API.Entities;

namespace API.DTOs
{
    public class EventDto
    {
        public int Id { get; set; }
        public int PinId { get; set; }
        public Pitch Pitch { get; set; }
        public List<AppUser> Participants { get; set; }
        public int MaxPlayers { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
