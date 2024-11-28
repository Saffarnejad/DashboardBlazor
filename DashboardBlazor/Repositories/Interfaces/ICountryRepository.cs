using DashboardBlazor.Data;

namespace DashboardBlazor.Repositories.Interfaces
{
    public interface ICountryRepository
    {
        public Task<Country> CreateAsync(Country country);
        public Task<bool> DeleteAsync(int id);
        public Task<IEnumerable<Country>> GetAllAsync();
        public Task<Country> GetAsync(int id);
        public Task<Country> UpdateAsync(Country country);
    }
}
