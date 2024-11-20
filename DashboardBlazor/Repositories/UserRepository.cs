using DashboardBlazor.Data;
using DashboardBlazor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DashboardBlazor.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetAsync(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => id == u.Id);
            if (user is null)
            {
                return new User();
            }
            return user;
        }
    }
}
