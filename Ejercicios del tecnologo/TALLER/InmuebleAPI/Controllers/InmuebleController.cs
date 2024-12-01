using InmuebleAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppApi.Model;
using WebAppApi.Services;

namespace InmuebleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmuebleController : ControllerBase
    {
        private readonly IInmuebleService _inmuebleService;
        private readonly ILogger<InmuebleController> _logger;

        public InmuebleController(IInmuebleService inmuebleService, ILogger<InmuebleController> logger)
        {
            _inmuebleService = inmuebleService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] bool? isActive = null)
        {
            var inmuebles = await _inmuebleService.GetAllInmueblesAsync(isActive);
            if (inmuebles == null || !inmuebles.Any())
            {
                return NotFound("No se encontraron inmuebles.");
            }
            return Ok(inmuebles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var inmueble = await _inmuebleService.GetInmuebleByIDAsync(id);
            if (inmueble == null)
            {
                return NotFound("Empleado no encontrado.");
            }
            return Ok(inmueble);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddUpdateInmueble inmuebleObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Devuelve los errores de validación del modelo
            }

            try
            {
                var inmueble = await _inmuebleService.AddInmuebleAsync(inmuebleObject);
                return CreatedAtAction(nameof(Get), new { id = inmueble.Id }, inmueble); // Devuelve el nuevo recurso y su URI
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear el inmueble");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] AddUpdateInmueble inmuebleObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var inmueble = await _inmuebleService.UpdateEmpleadoAsync(id, inmuebleObject);
                if (inmueble == null)
                {
                    return NotFound("Inmueble no encontrado.");
                }
                return Ok(inmueble);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al actualizar el inmueble");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _inmuebleService.DeleteInmuebleAsync(id);
                return Ok(new { message = "Inmueble eliminado exitosamente." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar el inmueble");
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}
