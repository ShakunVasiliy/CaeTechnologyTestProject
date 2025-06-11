using Common.Core.Data;
using Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SalesGraph.Infrastructure.Configurations
{
    internal class WeekSaleConfiguration : IEntityTypeConfiguration<WeekSale>
    {
        public void Configure(EntityTypeBuilder<WeekSale> builder)
        {
            builder.Property(x => x.Amount)
                .HasPrecision(19, 4)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(x => x.StartDate)
                .IsRequired()
                .HasColumnType(InfrastructureConsts.DbTypes.Date);
            builder.Property(x => x.EndDate)
                .IsRequired()
                .HasColumnType(InfrastructureConsts.DbTypes.Date);
        }
    }
}
