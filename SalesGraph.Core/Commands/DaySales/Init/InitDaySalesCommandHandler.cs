using Common.Core.Data.Contracts.Repositories;
using MediatR;

namespace SalesGraph.Core.Commands.DaySales.Init
{
    public class InitDaySalesCommandHandler : IRequestHandler<InitDaySalesCommand, InitDaySalesCommandResult>
    {
        private readonly IDaySaleRepository _daySaleRepository = null!;

        public InitDaySalesCommandHandler(IDaySaleRepository daySaleRepository)
        {
            _daySaleRepository = daySaleRepository;
        }

        public Task<InitDaySalesCommandResult> Handle(InitDaySalesCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
