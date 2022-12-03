using API.Entities;
using API.Extensions;

namespace API.DTOs
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }
        public string Nickname { get; set; }
        public DateTime Created { get; set; }
        public List<PhotoDto> Photos { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
    }
        
}
