using WebAppApi.Model;

namespace WebAppApi.Services
{
    public interface IEmpleadoService
    {
        Task<List<Empleado>> GetAllEmpleadosAsync(bool? isActive);
        Task<Empleado?> GetEmpleadoByIDAsync(int id);
        Task<Empleado> AddEmpleadoAsync(AddUpdateEmpleado obj);
        Task<Empleado?> UpdateEmpleadoAsync(int id, AddUpdateEmpleado obj);
        Task DeleteEmpleadoAsync(int id);

    }
}
