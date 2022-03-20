using Familia.Data.Context;
using Familia.Data.Repositories;
using Familia.Data.Seed;
using Familia.Domain.Interfaces.Repositories;
using Familia.Domain.Kernel.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Familia.Data
{
    public static class Startup
    {
        public static IConfiguration Configuration { get; private set; }

        public static IServiceCollection AddInfraDataIoC(this IServiceCollection services)
        {
            #region IoC dos Repositórios das classes de Entitdades
            services.AddScoped<IFamilyRepositorie, FamilyRepositorie>();
            #endregion


            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(
                    DatabaseConnection.ConnectionConfiguration
                    .GetConnectionString("DbConnection")));


            return services;
        }

        public static IApplicationBuilder SeedDatabase(this IApplicationBuilder app)
        {
            IServiceProvider serviceProvider = app.ApplicationServices.CreateScope().ServiceProvider;
            var context = serviceProvider.GetService<DatabaseContext>();
            var configuration = serviceProvider.GetService<IConfiguration>();
            new Initializer(context).Initialize();

            return app;
        }
    }
}
