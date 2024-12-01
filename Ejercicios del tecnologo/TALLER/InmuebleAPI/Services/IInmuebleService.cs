using InmuebleAPI.Model;

namespace InmuebleAPI.Services
{
    public interface IInmuebleService
    {
        Task<List<Inmueble>> GetAllInmueblesAsync(bool? isActive);
        Task<Inmueble?> GetInmuebleByIDAsync(int id);
        Task<Inmueble> AddInmuebleAsync(AddUpdateInmueble obj);
        Task<Inmueble?> UpdateEmpleadoAsync(int id, AddUpdateInmueble obj);
        Task DeleteInmuebleAsync(int id);
    }
}
