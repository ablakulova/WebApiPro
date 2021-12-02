using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using WebApiPro.Application.Common.Behaviours;
using FluentValidation;

namespace WebApiPro.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
           this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services
                .AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
            services.AddTransient(typeof(IPipelineBehavior<,>),
                typeof(ValidationBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>),
                typeof(LoggingBehaviour<,>));
            return services;
        }
    }
}
