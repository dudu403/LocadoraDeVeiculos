﻿using Microsoft.Extensions.Logging;
using Serilog;
using System.Reflection;

namespace LocadoraDeVeiculos.Infra.Orm.Compartilhado
{
    public class LocadoraDeVeiculosDbContext : DbContext
    {        
        public LocadoraDeVeiculosDbContext(DbContextOptions options) : base(options)
        {            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
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