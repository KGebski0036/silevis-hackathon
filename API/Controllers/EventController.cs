using API.Data;
using API.DTOs;
using API.Entities;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace API.Controllers
{
    public class EventController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public EventController(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> PostEvent([FromBody] Event ev)
        {
            await _context.Events.AddAsync(ev);
            await _context.SaveChangesAsync();
            return Ok(ev);
        }
        
        [HttpPost("join")]
        public async Task<ActionResult> JoinEvent(JoinEventDto dto) {
            var ev = await _context.Events.Where(x => x.Id == dto.eventId).Include(x => x.Participants).FirstOrDefaultAsync();
            var user = await _context.Users.Where(x=>x.UserName== dto.currentUserName).FirstOrDefaultAsync();

            if (user == null) return BadRequest();
            if (ev == null) return BadRequest();

            if (ev.Participants.Contains(user)) return BadRequest("You are already signed up.");

            ev.Participants.Add(user);

            await _context.SaveChangesAsync();
            return Ok();
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return await _context.Events.Include(x=>x.Pitch).Include(x=>x.Participants).ToListAsync();
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<EventDto>> GetEvent(int eventId)
        {
            return await _context.Events
                .Where(p => p.Id == eventId)
                .Include(x=>x.Pitch)
                .Include(x=>x.Participants)
                .ProjectTo<EventDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }
    }
}
