using Microsoft.EntityFrameworkCore;
namespace WebAppApi.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
