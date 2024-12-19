using DashboardBlazor.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DashboardBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>(options)
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Province> Provinces { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new CityConfiguration().Configure(builder.Entity<City>());
            new CountryConfiguration().Configure(builder.Entity<Country>());
            new ProductConfiguration().Configure(builder.Entity<Product>());
            new ProvinceConfiguration().Configure(builder.Entity<Province>());
            new RoleConfiguration().Configure(builder.Entity<Role>());
            new RoleClaimConfiguration().Configure(builder.Entity<RoleClaim>());
            new UserConfiguration().Configure(builder.Entity<User>());
            new UserClaimConfiguration().Configure(builder.Entity<UserClaim>());
            new UserLoginConfiguration().Configure(builder.Entity<UserLogin>());
            new UserRoleConfiguration().Configure(builder.Entity<UserRole>());
            new UserTokenConfiguration().Configure(builder.Entity<UserToken>());
        }
    }
}
