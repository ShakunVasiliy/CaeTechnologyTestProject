using Common.Core.Data.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;
using SalesGraph.Core.DI;
using SalesGraph.Core.UnitTests.Fakes.Repositories;

namespace SalesGraph.Core.UnitTests
{
    public class BaseTest
    {
        protected readonly IServiceScope _serviceScope;

        private static IServiceProvider _serviceProvider;

        static BaseTest()
        {
            var services = new ServiceCollection();
            services.AddCore();

            services.AddTransient<IDaySaleRepository, FakeDaySaleRepository>();

            _serviceProvider = services.BuildServiceProvider();
        }


        public BaseTest()
        {
            _serviceScope = _serviceProvider.CreateScope();
        }
    }
}
