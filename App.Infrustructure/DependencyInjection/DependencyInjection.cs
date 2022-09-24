using App.Infrustructure.Authentication;
using App.Services.Common.Interfaces.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace App.Infrustructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuthenticationInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            return services;
        }
    }
}
