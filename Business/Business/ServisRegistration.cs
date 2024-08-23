using Business.Abstract;
using Business.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class ServisRegistration
    {
        public static void addBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ISpot, SpotRepository>();
            services.AddScoped<IFlow, FlowRepository>();
            
        }
    }


}
