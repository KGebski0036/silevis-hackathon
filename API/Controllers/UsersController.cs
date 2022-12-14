using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {

        private readonly IUserRepository _context;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.GetPlayersAsync();


            return Ok(users);
        }

        [HttpGet("{username}")]

        public async Task<ActionResult<PlayerDto>> GetUser(string username)
        {
            return await _context.GetPlayerAsync(username);

        }
    }
}