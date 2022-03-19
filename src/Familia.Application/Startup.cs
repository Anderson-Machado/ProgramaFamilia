using Familia.Application.AppServices;
using Familia.Application.Interfaces;
using Familia.Data;
using Familia.Domain.Interfaces.Factory;
using Familia.Domain.Interfaces.Services;
using Familia.Domain.PointsFactory;
using Familia.Domain.PointsFactory.Factory;
using Familia.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familia.Application
{
    public static class Startup
    {
        public static IServiceCollection AddApplicationIoC(this IServiceCollection services)
        {

            #region Factory
            services.AddScoped<IPointsProcessFactory, PointsProcessFactory>()
                .AddScoped<IProviderPoints, ProviderPoints>()
            #endregion

            #region Service
            .AddScoped<IPointsServices, PointsServices>()
            #endregion

            #region Appservice
            .AddScoped<IPointsAppServices, PointsAppServices>()
            #endregion
            .AddInfraDataIoC();

            services.AddAutoMapper(typeof(Startup));

            return services;
        }

        public static IApplicationBuilder SeedData(this IApplicationBuilder app)
        {
            app.SeedDatabase();
            return app;

        }
    }
}

