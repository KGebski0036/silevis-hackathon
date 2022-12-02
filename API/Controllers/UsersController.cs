using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _context;
        public UsersController(IUserRepository context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return Ok(await _context.GetAllUsersAsync());
        }

        [HttpGet("{username}")]

        public async Task<ActionResult<AppUser>> GetUser(string username)
        {
            return await _context.GetUserByUserNameAsync(username);
        }
    }
}