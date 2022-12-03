using API.Entities;

namespace API.DTOs;

public class JoinEventDto {
    public string currentUserName { get; set; }
    public int eventId {get;set;}
}