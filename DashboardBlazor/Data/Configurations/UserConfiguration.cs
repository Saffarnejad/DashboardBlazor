using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashboardBlazor.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var user = new User()
            {
                Id = 1,
                UserName = "vira1368",
                NormalizedUserName = "VIRA1368",
                Email = "vira1368@gmail.com",
                NormalizedEmail = "VIRA1368@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+989357924021",
                PhoneNumberConfirmed = true
            };

            var passwordHasher = new PasswordHasher<User>();
            passwordHasher.HashPassword(user, "P@$$w0rd 12#4");

            builder
                .ToTable("Users")
                .HasData(user);
        }
    }
}
