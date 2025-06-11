using Common.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace SalesGraph.Infrastructure.Conventions
{
    internal class PluralizingTableNameConvention : IModelFinalizingConvention
    {
        public void ProcessModelFinalizing(IConventionModelBuilder modelBuilder, IConventionContext<IConventionModelBuilder> context)
        {
            foreach (var entityType in modelBuilder.Metadata.GetEntityTypes())
            {
                if (entityType.GetTableName() is null)
                {
                    entityType.SetTableName(WordHelper.Pluralize(entityType.DisplayName()));
                }
            }
        }
    }
}
