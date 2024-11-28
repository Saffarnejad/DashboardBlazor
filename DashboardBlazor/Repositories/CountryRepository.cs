using DashboardBlazor.Data;
using DashboardBlazor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DashboardBlazor.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Country> CreateAsync(Country country)
        {
            await _context.Countries.AddAsync(country);
            await _context.SaveChangesAsync();
            return country;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
            if (country != null)
            {
                _context.Countries.Remove(country);
                return (await _context.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country> GetAsync(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
            if (country != null)
            {
                return country;
            }
            return new Country();
        }

        public async Task<Country> UpdateAsync(Country country)
        {
            var countryInDb = await _context.Countries.FirstOrDefaultAsync(c => c.Id == country.Id);
            if (countryInDb != null)
            {
                countryInDb.Name = country.Name;
                _context.Countries.Update(countryInDb);
                await _context.SaveChangesAsync();
                return country;
            }
            return new Country();
        }
    }
}
