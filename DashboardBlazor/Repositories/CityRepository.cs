using DashboardBlazor.Data;
using DashboardBlazor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DashboardBlazor.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _context;

        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<City> CreateAsync(City city)
        {
            await _context.Cities.AddAsync(city);
            await _context.SaveChangesAsync();
            return city;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var city = await _context.Cities.FirstOrDefaultAsync(c => c.Id == id);
            if (city != null)
            {
                _context.Cities.Remove(city);
                return (await _context.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<IEnumerable<City>> GetAllAsync()
        {
            return await _context.Cities
                .Include(c => c.Province)
                .ToListAsync();
        }

        public async Task<City> GetAsync(int id)
        {
            var city = await _context.Cities.FirstOrDefaultAsync(c => c.Id == id);
            if (city != null)
            {
                return city;
            }
            return new City();
        }

        public async Task<City> UpdateAsync(City city)
        {
            var cityInDb = await _context.Cities.FirstOrDefaultAsync(c => c.Id == city.Id);
            if (cityInDb != null)
            {
                cityInDb.Name = city.Name;
                _context.Cities.Update(cityInDb);
                await _context.SaveChangesAsync();
                return city;
            }
            return new City();
        }
    }
}
