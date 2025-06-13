using Common.Core.Data.Contracts.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SalesGraph.Core.Commands.DaySales.Init;

namespace SalesGraph.Core.UnitTests.Commands.DaySales
{
    public class InitDaySaleCommandTest : BaseTest
    {
        private readonly IMediator _mediator = null!;

        public InitDaySaleCommandTest()
        {
            _mediator = _serviceScope.ServiceProvider.GetService<IMediator>()!;
        }

        //private readonly IDaySaleRepository _daySaleRepository;
        //public InitDaySaleCommandTest()
        //{
        //    _daySaleRepository = _serviceScope.ServiceProvider.GetService<IDaySaleRepository>()!;
        //}


        [Fact]
        public async Task Init()
        {
            var command = new InitDaySalesCommand()
            {
                StartDate = new DateOnly(2025, 06, 01),
                EndDate = new DateOnly(2025, 06, 02)
            };

            var commandResult = await _mediator.Send(command);
            var result = commandResult?.Count == 2;

            Assert.True(result);

            //Assert.True(false);
        }
    }
}
