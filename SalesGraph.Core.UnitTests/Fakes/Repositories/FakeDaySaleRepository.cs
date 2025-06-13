using Common.Core.Data;
using Common.Core.Data.Contracts.Repositories;

namespace SalesGraph.Core.UnitTests.Fakes.Repositories
{
    public class FakeDaySaleRepository : IDaySaleRepository
    {
        public Task<IReadOnlyCollection<DaySale>> GetByRangeAsync(DateOnly startDate, DateOnly endDate)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountAsync()
        {
            throw new NotImplementedException();
        }
    }
}
