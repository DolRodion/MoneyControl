using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MoneyControl.Command.Core
{
    public static class RegisterCommandExtension
    {
        public static IServiceCollection RegisterContainer(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
