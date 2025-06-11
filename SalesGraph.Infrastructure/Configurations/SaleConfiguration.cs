using Common.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SalesGraph.Infrastructure.Configurations
{
    internal class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.Property(x => x.Date)
                .IsRequired();
            builder.Property(x => x.Amount)
                .HasPrecision(19, 4)
                .IsRequired()
                .HasDefaultValue(0);
        }
    }
}
