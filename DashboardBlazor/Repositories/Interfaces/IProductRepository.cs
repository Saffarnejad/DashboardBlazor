using DashboardBlazor.Data;

namespace DashboardBlazor.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public Task<Product> CreateAsync(Product product);
        public Task<bool> DeleteAsync(int id);
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<Product> GetAsync(int id);
        public Task<Product> UpdateAsync(Product product);
    }
}
