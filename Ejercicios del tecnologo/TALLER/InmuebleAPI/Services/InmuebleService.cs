using Microsoft.EntityFrameworkCore;
using InmuebleApi.Model;
using InmuebleAPI.Model;

namespace InmuebleAPI.Services
{
    public class InmuebleService : IInmuebleService
    {
        private readonly ApplicationDbContext _context;

        public InmuebleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Inmueble>> GetAllInmueblesAsync(bool? isActive = null)
        {
            return await (isActive == null
                ? _context.Inmuebles.ToListAsync()
                : _context.Inmuebles.Where(emp => emp.IsActive == isActive).ToListAsync());
        }

        public async Task<Inmueble?> GetEmpleadoByIDAsync(int id)
        {
            return await _context.Inmuebles.FindAsync(id);
        }

        public async Task<Inmueble> AddInmuebleAsync(AddUpdateInmueble inmuebleData)
        {
            var newInmueble = new Inmueble
            {
                Casa = inmuebleData.Casa,
                AreaTerreno = inmuebleData.AreaTerreno,
                CostoPorMetroCuadrado = inmuebleData.CostoPorMetroCuadrado,
                CostoInfraestructura = inmuebleData.CostoInfraestructura,
                PorcentajeGanancia = inmuebleData.PorcentajeGanancia,
                IsActive = inmuebleData.IsActive;
            };

            _context.Inmuebles.Add(newInmueble);
            await _context.SaveChangesAsync();
            return newInmueble;
        }

        public async Task<Inmueble?> UpdateInmuebleAsync(int id, AddUpdateInmueble inmuebleData)
        {
            var inmueble = await _context.Inmuebles.FindAsync(id);
            if (inmueble == null) return null;

            inmueble.Casa = inmuebleData.Casa;
            inmueble.AreaTerreno = inmuebleData.AreaTerreno;
            inmueble.CostoPorMetroCuadrado = inmuebleData.CostoPorMetroCuadrado;
            inmueble.CostoInfraestructura = inmuebleData.CostoInfraestructura;
            inmueble.IsActive = inmuebleData.IsActive;

            // Marcar la entidad como modificada para que Entity Framework realice el seguimiento de los cambios
            _context.Entry(inmueble).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return inmueble;
        }

        public async Task DeleteEmpleadoAsync(int id)
        {
            var inmueble = await _context.Inmuebles.FindAsync(id);
            if (inmueble != null)
            {
                _context.Empleados.Remove(inmueble);
                await _context.SaveChangesAsync();
            }
        }
    }
}
