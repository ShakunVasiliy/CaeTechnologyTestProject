using MediatR;

namespace SalesGraph.Core.Commands.DaySales.Init
{
    public record class InitDaySalesCommand : IRequest<InitDaySalesCommandResult>
    {
        public DateOnly? StartDate { get; init; }
        public DateOnly? EndDate { get; init; }
    }
}
