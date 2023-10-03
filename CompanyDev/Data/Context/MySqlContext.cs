using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        //public MySqlContext() : base() { }

        public DbSet<DiretorEntity> DiretorEntity { get; set; }
        public DbSet<GerenteEntity> GerenteEntity { get; set; }
        public DbSet<EquipeEntity> EquipeEntity { get; set; }
        public DbSet<FuncionarioEntity> FuncionarioEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DiretorMapping());
            modelBuilder.ApplyConfiguration(new FuncionarioMapping());
            modelBuilder.ApplyConfiguration(new EquipeMapping());
            modelBuilder.ApplyConfiguration(new GerenteMapping());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DB");
                optionsBuilder.UseMySql(connectionString,
                          new MySqlServerVersion(new Version(5, 7)));
            }
        }
    }
}
