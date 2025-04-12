using DevOpsTODO.Controllers;
using DevOpsTODO.Data.Modelos;
using DevOpsTODO.Data;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DevOpsTODO.Testes
{
    public class NotaControllerTest
    {
        [Fact]
        public async Task Get_DeveRetornarActionResult()
        {
            // Arrange
            var mockContexto = new Mock<Contexto>();
            var notas = new List<Nota>
            {
                new Nota { Titulo = "Nota 1", Conteudo = "Conteúdo 1" },
                new Nota { Titulo = "Nota 2", Conteudo = "Conteúdo 2" }
            };
            var controller = new NotaController(mockContexto.Object);

            controller.Post(notas[0]);
            controller.Post(notas[1]);
            var result = await controller.GetAll();

            var okResult = Assert.IsType<ActionResult<List<Nota>>>(result);
        }

        [Fact]
        public async Task Post_DeveAdicionarNotaERetornarCreated()
        {

            var mockContexto = new Mock<Contexto>();
            var nota = new Nota { Titulo = "Nova Nota", Conteudo = "Novo Conteúdo" };
            var controller = new NotaController(mockContexto.Object);

            var result = await controller.Post(nota);

            var okResult = Assert.IsType<CreatedResult>(result);
        }


        [Fact]
        public async Task PostComNotaNull_DeveRetornarBadRequest()
        {
            var mockContexto = new Mock<Contexto>();
            var controller = new NotaController(mockContexto.Object);
            
            var result = await controller.Post(null);

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
