using System.Reflection.Metadata.Ecma335;

namespace API.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
