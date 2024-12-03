using InmuebleAPI.Model;

namespace InmuebleAPI.Services
{
    public interface IInmuebleService
    {
        Task<List<InmuebleService>> GetAllInmueblesAsync(bool? isActive);
        Task<InmuebleService?> GetInmuebleByIDAsync(int id);
        Task<InmuebleService> AddInmuebleAsync(AddUpdateInmueble obj);
        Task<InmuebleService?> UpdateEmpleadoAsync(int id, AddUpdateInmueble obj);
        Task DeleteInmuebleAsync(int id);
    }
}
