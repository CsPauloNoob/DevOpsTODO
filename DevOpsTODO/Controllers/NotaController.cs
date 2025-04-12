using DevOpsTODO.Data;
using DevOpsTODO.Data.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace DevOpsTODO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotaController : ControllerBase
    {
        private readonly Contexto _contexto;

        public NotaController(Contexto contexto)
        {
            _contexto = contexto;
        }


        [HttpGet]
        public async Task<ActionResult<List<Nota>>> GetAll()
        {

            var result = await _contexto.GetAll();

            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Nota nota)
        {
            var result = await _contexto.AdicionarNota(nota);

            if (result)
                return Created("Nota adicionada com sucesso", nota);
            else
                return BadRequest("Erro ao adicionar nota");
        }
    }
}
