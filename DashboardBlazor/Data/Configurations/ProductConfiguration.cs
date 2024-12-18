using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DashboardBlazor.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product { Id = 1, Name = "Keyboard", CreatedDateTime = new DateTime(2024, 12, 10) });
            builder.HasData(new Product { Id = 2, Name = "Mouse", CreatedDateTime = new DateTime(2024, 12, 10) });
            builder.HasData(new Product { Id = 3, Name = "Monitor", CreatedDateTime = new DateTime(2024, 12, 11) });
            builder.HasData(new Product { Id = 4, Name = "Modem", CreatedDateTime = new DateTime(2024, 12, 12) });
        }
    }
}
