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
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var ctx = new Contexto();

            var result = await ctx.GetAll();

            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Nota nota)
        {
            var ctx = new Contexto();
            var result = await ctx.AdicionarNota(nota);

            if (result)
                return Ok("Nota adicionada com sucesso");
            else
                return BadRequest("Erro ao adicionar nota");
        }
    }
}
