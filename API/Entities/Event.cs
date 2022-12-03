using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public List<AppUser> Participants { get; set; }
        public int MaxPlayers { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public int PitchId { get; set; }
        public Pitch Pitch { get; set; }
        public string Description { get; set; }
    }
}