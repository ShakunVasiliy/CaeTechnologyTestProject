using Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
    }
}
