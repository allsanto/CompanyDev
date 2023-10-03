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
    public class FuncionarioController : ControllerBase
    {
        private readonly FuncionarioService _service;

        public FuncionarioController(FuncionarioService service)
        {
            _service = service;
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<FuncionarioEntity>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpPost("createFuncionario")]
        public async Task<IActionResult> CreateFuncionario([FromBody] FuncionarioRequest Funcionario)
        {
            var result = await _service.CreateFuncionario(Funcionario);
            return Ok(result);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(FuncionarioEntity))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("getById/{id}")]
        public async Task<FuncionarioEntity> GetById(int id)
        {
            return await _service.GetFuncionarioById(id);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("createFuncionario/{id}")]
        public async Task<bool> DeleteFuncionario(int id)
        {
            return await _service.DeleteFuncionario(id);
        }

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        [HttpGet("filterByName/{nome}")]
        public async Task<IEnumerable<FuncionarioEntity>> FilterByName(string nome)
        {
            return await _service.FilterByName(nome);
        }
    }
}
