using Common.Core.Data.Contracts;

namespace Common.Core.Data
{
    public class Sale : IEntityWithId
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
