using Microsoft.EntityFrameworkCore;
using Familia.Domain.Entities;
using Familia.Domain.Kernel.Repository;
using Microsoft.Extensions.Configuration;

namespace Familia.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Family> Family { get; set; }
        public DbSet<Dependent> Dependents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    DatabaseConnection.ConnectionConfiguration.GetConnectionString("DbConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new WeatherForecastMap());
        }

    }
}
