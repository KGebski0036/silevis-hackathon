using API.Extensions;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Nickname { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public List<Photo> Photos { get; set; } = new List<Photo>();

        [JsonIgnore]
        public List<Event> RegisteredEvents { get; set; } = new List<Event>();

        public string Gender { get; set; }
        public string Country { get; set; }
        //public int GetAge()
        //{
        //    return DateOfBirth.CalculateAge();
        //}
    }
}