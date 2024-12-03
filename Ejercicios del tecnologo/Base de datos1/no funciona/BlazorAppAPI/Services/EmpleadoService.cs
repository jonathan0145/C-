using BlazorAppAPI.Models;
using System.Net.Http.Json;

namespace BlazorAppAPI.Services
{
    public class EmpleadoService
    {
        private readonly HttpClient _httpClient;

        public EmpleadoService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            //_baseUri = configuration.GetValue<string>("ApiSettings:BaseUrl");
        }

        public async Task<List<Empleado>>
        GetEmpleadosAsync(bool? isActive = null)
        {
            var query = isActive.HasValue ? $"?isActive={isActive}" : string.Empty;
            return await _httpClient.GetFromJsonAsync<List<Empleado>>($"empleados{query}") ?? new List<Empleado>(); // Ajusta la ruta según tu API
        }

        public async Task<Empleado> GetEmpleadoByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Empleado>($"empleados/{id}") ?? new Empleado(); // Ajusta la ruta según tu API
        }

        public async Task<Empleado> CreateEmpleadoAsync(AddUpdateEmpleado empleado)
        {
            var response = await _httpClient.PostAsJsonAsync("empleados", empleado);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Empleado>();
        }

        public async Task<bool> DeleteEmpleadoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"empleados/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<Empleado> UpdateEmpleadoAsync(int id, AddUpdateEmpleado empleado)
        {
            var response = await _httpClient.PutAsJsonAsync($"empleados/{id}", empleado);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Empleado>();
        }
    }
}
