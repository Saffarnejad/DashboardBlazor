using DashboardBlazor.Data;
using DashboardBlazor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DashboardBlazor.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(c => c.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                return (await _context.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(c => c.Id == id);
            if (product != null)
            {
                return product;
            }
            return new Product();
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            var productInDb = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.Id);
            if (productInDb != null)
            {
                productInDb.Name = product.Name;
                _context.Products.Update(productInDb);
                await _context.SaveChangesAsync();
                return product;
            }
            return new Product();
        }
    }
}
