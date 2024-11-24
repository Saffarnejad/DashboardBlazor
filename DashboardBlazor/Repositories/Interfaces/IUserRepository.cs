using DashboardBlazor.Data;

namespace DashboardBlazor.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllAsync();
        public Task<User> GetAsync(int id);
        public Task<IEnumerable<string>> GetRolesAsync(User user);
    }
}
