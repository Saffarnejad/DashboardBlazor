using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashboardBlazor.Data.Configurations
{
    public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.ToTable("UserTokens");
        }
    }
}
