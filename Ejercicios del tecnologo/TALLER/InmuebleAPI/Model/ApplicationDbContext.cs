using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Pomelo.EntityFrameworkCore.MySql;

namespace InmuebleAPI.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Inmuebles = Set<Inmueble>();
        }

        public DbSet<Inmueble> Inmuebles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()

                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")

                    .Build();

                optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"), ServerVersion.AutoDetect(new MySqlConnection()));
            }
        }
    }
}
