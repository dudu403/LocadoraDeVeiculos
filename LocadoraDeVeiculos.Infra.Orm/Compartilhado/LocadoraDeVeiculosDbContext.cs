using LocadoraDeVeiculos.Dominio.Compartilhado;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Reflection;

namespace LocadoraDeVeiculos.Infra.Orm.Compartilhado
{
    public class LocadoraDeVeiculosDbContext : DbContext
    {
        /* Para criar objetos DbContext o padrão é utilizar a classe "DbContextOptions"
         * 
         * O código abaixo é uma "gambeta" :-)             
         * 
         * private string connectionString;
         * 
         * public LocadoraVeiculosDbContext(string connectionString)
         * {
         *     this.connectionString = connectionString;
         * }
        */
        public LocadoraDeVeiculosDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /* Para criar objetos DbContext o padrão é utilizar a classe "DbContextOptions"
             * 
             * O código abaixo é uma "gambeta" :-)             
             * 
             * if (string.IsNullOrEmpty(connectionString))
             * {
             *     var configuration = new ConfigurationBuilder()
             *        .SetBasePath(Directory.GetCurrentDirectory())
             *        .AddJsonFile("appsettings.json")
             *        .Build();
             * 
             *     connectionString = configuration.GetConnectionString("SqlServer");
             * }            
             * 
             * optionsBuilder.UseSqlServer(connectionString);
             *
            */

            ILoggerFactory loggerFactory = LoggerFactory.Create((x) =>
            {
                x.AddSerilog(Log.Logger); //instalar o pacote Serilog.Extensions.Logging
            });

            optionsBuilder.UseLoggerFactory(loggerFactory);

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly assembly = typeof(LocadoraDeVeiculosDbContext).Assembly;

            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}