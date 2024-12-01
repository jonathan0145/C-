using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppApi.Model;
using WebAppApi.Services;

namespace WebAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;

        private readonly ILogger<EmpleadoController> _logger;

        public EmpleadoController(IEmpleadoService empleadoService, ILogger<EmpleadoController> logger)
        {
            _empleadoService = empleadoService;
            _logger = logger;
        }

        /// <summary>
        /// Obtiene todos los empleados, opcionalmente filtrando por estado activo.
        /// </summary>
        /// <param name="isActive">Parámetro booleano opcional para filtrar por empleados activos (true) o inactivos (false). Null para obtener todos.</param>
        /// <returns>Un IActionResult con una lista de empleados (OK) o NotFound si no se encuentran empleados.</returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] bool? isActive = null)
        {
            var empleados = await _empleadoService.GetAllEmpleadosAsync(isActive);
            if (empleados == null || !empleados.Any())
            {
                return NotFound("No se encontraron empleados.");
            }
            return Ok(empleados);
        }

        /// <summary>
        /// Obtiene un empleado específico por ID.
        /// </summary>
        /// <param name="id">El ID entero del empleado a obtener.</param>
        /// <returns>Un IActionResult con el objeto empleado (OK) o NotFound si el empleado no se encuentra.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var empleado = await _empleadoService.GetEmpleadoByIDAsync(id);
            if (empleado == null)
            {
                return NotFound("Empleado no encontrado.");
            }
            return Ok(empleado);
        }

        /// <summary>
        /// Crea un nuevo empleado.
        /// </summary>
        /// <param name="empleadoObject">Una instancia de la clase AddUpdateEmpleado con los datos del empleado.</param>
        /// <returns>Un IActionResult con un mensaje de éxito y el ID del empleado recién creado (OK) o BadRequest si no se puede crear el empleado.</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddUpdateEmpleado empleadoObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Devuelve los errores de validación del modelo
            }

            try
            {
                var empleado = await _empleadoService.AddEmpleadoAsync(empleadoObject);
                return CreatedAtAction(nameof(Get), new { id = empleado.Id }, empleado); // Devuelve el nuevo recurso y su URI
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear el empleado");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Actualiza un empleado existente.
        /// </summary>
        /// <param name="id">El ID entero del empleado a actualizar.</param>
        /// <param name="empleadoObject">Una instancia de la clase AddUpdateEmpleado con los datos actualizados del empleado.</param>
        /// <returns>Un IActionResult con un mensaje de éxito y el ID del empleado actualizado (OK) o NotFound si el empleado no se encuentra, o BadRequest si la actualización falla.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] AddUpdateEmpleado empleadoObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var empleado = await _empleadoService.UpdateEmpleadoAsync(id, empleadoObject);
                if (empleado == null)
                {
                    return NotFound("Empleado no encontrado.");
                }
                return Ok(empleado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al actualizar el empleado");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Elimina un empleado.
        /// </summary>
        /// <param name="id">El ID entero del empleado a eliminar.</param>
        /// <returns>Un IActionResult con un mensaje de éxito y el ID del empleado eliminado (OK) o NotFound si el empleado no se encuentra.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _empleadoService.DeleteEmpleadoAsync(id);
                return Ok(new { message = "Empleado eliminado exitosamente." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar el empleado");
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}
