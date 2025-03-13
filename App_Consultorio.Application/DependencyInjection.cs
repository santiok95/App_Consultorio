using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Consultorio.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(o =>
            {
                o.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });


            return services;
        }
    }
}
