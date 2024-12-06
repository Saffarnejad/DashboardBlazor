using DashboardBlazor.Data;

namespace DashboardBlazor.Repositories.Interfaces
{
    public interface ICityRepository
    {
        public Task<City> CreateAsync(City city);
        public Task<bool> DeleteAsync(int id);
        public Task<IEnumerable<City>> GetAllAsync();
        public Task<City> GetAsync(int id);
        public Task<City> UpdateAsync(City city);
    }
}
