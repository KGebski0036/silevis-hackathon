using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class PitchController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public PitchController(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pitch>>> GetPitches()
        {
            var Pitch = await _context.Pitches.ToListAsync();

            return Pitch;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<PitchDto>> GetPitch(int pitchId)
        {
            return await _context.Pitches
                .Where(p => p.Id == pitchId)
                .ProjectTo<PitchDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }



        [HttpGet("events/{pitchId}")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEventsForPitch([FromRoute] int pitchId) {

            return await _context.Events.Where(x => x.PitchId == pitchId).Include(x=>x.Participants).ToListAsync();
            
        }
            
        [HttpPost]
        public async Task<ActionResult<PitchDto>> AddPitch(PitchDto newPitch)
        {
            if (string.IsNullOrEmpty(newPitch.Name)) return BadRequest("The name can't be empty");

            await _context.Pitches.AddAsync(new Pitch()
            {
                Name = newPitch.Name,
                Description = newPitch.Description,
                CoordLat = newPitch.CoordLat,
                CoordLon = newPitch.CoordLon
            });

            await _context.SaveChangesAsync();

            return newPitch;
        }
    }
}