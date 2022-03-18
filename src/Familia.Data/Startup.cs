using Familia.Data.Context;
using Familia.Data.Repositories;
using Familia.Domain.Interfaces.Repositories;
using Familia.Domain.Kernel.Repository;
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
    }
}
