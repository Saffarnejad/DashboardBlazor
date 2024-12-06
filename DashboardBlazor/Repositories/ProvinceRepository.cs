using DashboardBlazor.Data;
using DashboardBlazor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DashboardBlazor.Repositories
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly ApplicationDbContext _context;

        public ProvinceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Province> CreateAsync(Province province)
        {
            await _context.Provinces.AddAsync(province);
            await _context.SaveChangesAsync();
            return province;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var province = await _context.Provinces.FirstOrDefaultAsync(p => p.Id == id);
            if (province != null)
            {
                _context.Provinces.Remove(province);
                return (await _context.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<IEnumerable<Province>> GetAllAsync()
        {
            return await _context.Provinces.ToListAsync();
        }

        public async Task<Province> GetAsync(int id)
        {
            var province = await _context.Provinces.FirstOrDefaultAsync(p => p.Id == id);
            if (province != null)
            {
                return province;
            }
            return new Province();
        }

        public async Task<Province> UpdateAsync(Province province)
        {
            var provinceInDb = await _context.Provinces.FirstOrDefaultAsync(p => p.Id == province.Id);
            if (provinceInDb != null)
            {
                provinceInDb.Name = province.Name;
                _context.Provinces.Update(provinceInDb);
                await _context.SaveChangesAsync();
                return province;
            }
            return new Province();
        }
    }
}
