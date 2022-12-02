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
<<<<<<< HEAD
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
=======
        private readonly IUserRepository _context;
        public UsersController(IUserRepository context)
>>>>>>> Karol
        {
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
<<<<<<< HEAD
            return Ok(await _userRepository.GetAllUsersAsync());

=======
            return Ok(await _context.GetAllUsersAsync());
>>>>>>> Karol
        }

        [HttpGet("{username}")]

        public async Task<ActionResult<AppUser>> GetUser(string username)
        {
<<<<<<< HEAD
            return await _userRepository.GetUserByUserNameAsync(username);
=======
            return await _context.GetUserByUserNameAsync(username);
>>>>>>> Karol
        }
    }
}