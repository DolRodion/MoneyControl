using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MoneyControl.Application.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControll.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
  

            services.AddSingleton<IConnectionStringProvider, ConnectionStringProvider>();

            return services;
        }
    }
}
