using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashboardBlazor.Data.Configurations
{
    public class UserLoginConfiguration : IEntityTypeConfiguration<UserLogin>
    {
        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            builder.ToTable("UserLogins");
        }
    }
}
