﻿using App.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AuthenticationApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationServiceApp, AuthenticationServiceApp>();
            return services;
        }
    }
}