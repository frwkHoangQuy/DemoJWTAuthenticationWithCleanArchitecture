﻿using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection InfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("Default"), 
                b => b.MigrationsAssembly(typeof(ServiceContainer).Assembly.FullName)), 
                ServiceLifetime.Scoped); 

            return services;
        }
    }
}
