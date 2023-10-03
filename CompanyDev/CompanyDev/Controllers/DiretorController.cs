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
    public class DiretorController : ControllerBase
    {
        private readonly DiretorService _service;

        public DiretorController(DiretorService service)
        {
            _service = service;
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<DiretorEntity>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpPost("createDiretor")]
        public async Task<IActionResult> CreateDiretor([FromBody] DiretorRequest Diretor)
        {
            var result = await _service.CreateDiretor(Diretor);
            return Ok(result);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(DiretorEntity))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("getById/{id}")]
        public async Task<DiretorEntity> GetById(int id)
        {
            return await _service.GetDiretorById(id);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("createDiretor/{id}")]
        public async Task<bool> DeleteDiretor(int id)
        {
            return await _service.DeleteDiretor(id);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("filterByName/{nome}")]
        public async Task<IEnumerable<DiretorEntity>> FilterByName(string nome)
        {
            return await _service.FilterByName(nome);
        }
    }
}
