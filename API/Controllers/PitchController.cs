using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class PitchController : BaseApiController
    {
        private readonly DataContext _context;
        public PitchController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pitch>>> GetPitch()
        {
            var Pitch = await _context.Pitches.ToListAsync();

            return Pitch;
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