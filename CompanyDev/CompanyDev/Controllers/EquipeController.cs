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
    public class EquipeController : ControllerBase
    {
        private readonly EquipeService _service;

        public EquipeController(EquipeService service)
        {
            _service = service;
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<EquipeEntity>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpPost("createEquipe")]
        public async Task<IActionResult> CreateEquipe([FromBody] EquipeRequest Equipe)
        {
            var result = await _service.CreateEquipe(Equipe);
            return Ok(result);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(EquipeEntity))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("getById/{id}")]
        public async Task<EquipeEntity> GetById(int id)
        {
            return await _service.GetEquipeById(id);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("createEquipe/{id}")]
        public async Task<bool> DeleteEquipe(int id)
        {
            return await _service.DeleteEquipe(id);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("filterByName/{nome}")]
        public async Task<IEnumerable<EquipeEntity>> FilterByName(string nome)
        {
            return await _service.FilterByName(nome);
        }
    }
}
