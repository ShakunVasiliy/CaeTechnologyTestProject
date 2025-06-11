using Common.Core.Data;
using Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SalesGraph.Infrastructure.Configurations
{
    internal class DaySaleConfiguration : IEntityTypeConfiguration<DaySale>
    {
        public void Configure(EntityTypeBuilder<DaySale> builder)
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
