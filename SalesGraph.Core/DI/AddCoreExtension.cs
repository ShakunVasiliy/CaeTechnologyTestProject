using Common.Core.Behaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace SalesGraph.Core.DI
{
    public static class AddCoreExtension
    {
        public static IServiceCollection AddCore(this IServiceCollection services) 
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddCoreExtension).Assembly));
            services.AddValidatorsFromAssembly(typeof(AddCoreExtension).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}
