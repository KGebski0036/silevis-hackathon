using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Reflection.Metadata.Ecma335;

namespace API.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserRepository(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context=context;
        }

        public async Task<IEnumerable<AppUser>> GetAllUsersAsync()
        {
            return await _context.Users.Include(p => p.Photos).ToListAsync();

        }

        public async Task<IEnumerable<PlayerDto>> GetPlayersAsync()
        {
            return await _context.Users
                .ProjectTo<PlayerDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<PlayerDto> GetPlayerAsync(string username)
        {
            return await _context.Users
                .Where(x => x.UserName == username)
                .ProjectTo<PlayerDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<AppUser> GetUserByUserNameAsync(string username)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(AppUser user)
        {
            _context.Entry(user).State= EntityState.Modified;
        }
    }
}
