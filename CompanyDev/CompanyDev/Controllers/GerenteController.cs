using Domain.Entities;
using Domain.Request;
using Microsoft.AspNetCore.Mvc;
using Services;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace CompanyDev.Controllers
{
    [Route("company")]
    [ApiController]
    public class GerenteController : ControllerBase
    {
        private readonly GerenteService _service;

        public GerenteController(GerenteService service)
        {
            _service = service;
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<GerenteEntity>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpPost("createGerente")]
        public async Task<IActionResult> CreateGerente([FromBody] GerenteRequest gerente)
        {
            var result = await _service.CreateGerente(gerente);
            return Ok(result);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GerenteEntity))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("getById/{id}")]
        public async Task<GerenteEntity> GetById(int id)
        {
            return await _service.GetGerenteById(id);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("createGerente/{id}")]
        public async Task<bool> DeleteGerente(int id)
        {
            return await _service.DeleteGerente(id);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("filterByName/{nome}")]
        public async Task<IEnumerable<GerenteEntity>> FilterByName(string nome)
        {
            return await _service.FilterByName(nome);
        }
    }
}
