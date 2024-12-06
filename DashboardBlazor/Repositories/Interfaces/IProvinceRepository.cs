using DashboardBlazor.Data;

namespace DashboardBlazor.Repositories.Interfaces
{
    public interface IProvinceRepository
    {
        public Task<Province> CreateAsync(Province province);
        public Task<bool> DeleteAsync(int id);
        public Task<IEnumerable<Province>> GetAllAsync();
        public Task<Province> GetAsync(int id);
        public Task<Province> UpdateAsync(Province province);
    }
}
