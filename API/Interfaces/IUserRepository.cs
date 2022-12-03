using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        public void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetAllUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUserNameAsync(string username);
        Task<IEnumerable<PlayerDto>> GetPlayersAsync();
        Task<PlayerDto> GetPlayerAsync(string username);
    }
}
