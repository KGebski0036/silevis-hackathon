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


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            var Events = await _context.Events.ToListAsync();

            return Events;
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<EventDto>> GetEvent(int eventId)
        {
            return await _context.Events
                .Where(p => p.Id == eventId)
                .ProjectTo<EventDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }
    }
}
