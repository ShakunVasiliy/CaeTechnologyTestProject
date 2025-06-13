namespace Common.Core.Data.Contracts.Repositories
{
    public interface IBaseRangeSaleRepository<T> : IRepository<T>
        where T : BaseRangeSale
    {
        public Task<int> GetCountAsync();
        public Task<IReadOnlyCollection<T>> GetByRangeAsync(DateOnly startDate, DateOnly endDate);
    }
}
