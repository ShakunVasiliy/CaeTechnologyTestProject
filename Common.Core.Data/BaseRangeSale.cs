using Common.Core.Data.Contracts;

namespace Common.Core.Data
{
    public abstract class BaseRangeSale : IEntityWithId
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
