using Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SalesGraph.Infrastructure.Configurations;
using SalesGraph.Infrastructure.Conventions;

namespace SalesGraph.Infrastructure
{
    public class SaleGraphContext : DbContext
    {
        public SaleGraphContext()
            : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile(InfrastructureConsts.Config.DefaultFileName)
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
            var configConnectionString = config.GetConnectionString(InfrastructureConsts.Config.ConnectionString.SaleGraphDb);

            optionsBuilder.UseSqlServer(configConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SaleConfiguration());
            modelBuilder.ApplyConfiguration(new DaySaleConfiguration());
            modelBuilder.ApplyConfiguration(new WeekSaleConfiguration());
            modelBuilder.ApplyConfiguration(new MonthSaleConfiguration());
            modelBuilder.ApplyConfiguration(new QuarterSaleConfiguration());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Add(_ => new PluralizingTableNameConvention());
        }
    }
}
