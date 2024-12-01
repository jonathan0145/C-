using Microsoft.EntityFrameworkCore;
using WebAppApi.Model;

namespace WebAppApi.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly ApplicationDbContext _context;

        public EmpleadoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Empleado>> GetAllEmpleadosAsync(bool? isActive = null)
        {
            return await (isActive == null
                ? _context.Empleados.ToListAsync()
                : _context.Empleados.Where(emp => emp.IsActive == isActive).ToListAsync());
        }

        public async Task<Empleado?> GetEmpleadoByIDAsync(int id)
        {
            return await _context.Empleados.FindAsync(id);
        }

        public async Task<Empleado> AddEmpleadoAsync(AddUpdateEmpleado empleadoData)
        {
            var newEmpleado = new Empleado
            {
                Identificacion = empleadoData.Identificacion,
                Nombre = empleadoData.Nombre,
                HorasTrabajadas = empleadoData.HorasTrabajadas,
                SueldoPorHora = empleadoData.SueldoPorHora,
                IsActive = empleadoData.IsActive,
            };

            _context.Empleados.Add(newEmpleado);
            await _context.SaveChangesAsync();
            return newEmpleado;
        }

        public async Task<Empleado?> UpdateEmpleadoAsync(int id, AddUpdateEmpleado empleadoData)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null) return null;

            empleado.Identificacion = empleadoData.Identificacion;
            empleado.Nombre = empleadoData.Nombre;
            empleado.HorasTrabajadas = empleadoData.HorasTrabajadas;
            empleado.SueldoPorHora = empleadoData.SueldoPorHora;
            empleado.IsActive = empleadoData.IsActive;

            // Marcar la entidad como modificada para que Entity Framework realice el seguimiento de los cambios
            _context.Entry(empleado).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return empleado;
        }

        public async Task DeleteEmpleadoAsync(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                await _context.SaveChangesAsync();

            }
        }
    }
}