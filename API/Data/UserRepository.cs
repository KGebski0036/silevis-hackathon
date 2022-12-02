using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Reflection.Metadata.Ecma335;

namespace API.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context=context;
        }

        public async Task<IEnumerable<AppUser>> GetAllUsersAsync()
        {
<<<<<<< HEAD
            return await _context.Users.Include(p =>p.Photos).ToListAsync();
=======
            return await _context.Users.Include(p => p.Photos).ToListAsync();
>>>>>>> Karol
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
