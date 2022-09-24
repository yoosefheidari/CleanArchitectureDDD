using App.Infrustructure.Authentication;
using App.Services.Common.Interfaces.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrustructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuthenticationInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            return services;
        }
    }
}
