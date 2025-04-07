using DevOpsTODO.Data;
using DevOpsTODO.Data.Modelos;

namespace DevOpsTODO.Testes
{
    public class ContextoTest
    {

        [Fact]
        public async Task AdicionarNota_DeveRetornarTrue()
        {
            var contexto = new Contexto();
            var nota = new Nota { Titulo = "Teste", Conteudo = "Conteúdo de teste" };

            var resultado = await contexto.AdicionarNota(nota);

            Assert.True(resultado);
        }

        [Fact]
        public async Task GetAll_DeveRetornarListaDeNotas()
        {
            var contexto = new Contexto();
            var nota1 = new Nota { Titulo = "Teste 1", Conteudo = "Conteúdo de teste 1" };
            var nota2 = new Nota { Titulo = "Teste 2", Conteudo = "Conteúdo de teste 2" };
            await contexto.AdicionarNota(nota1);
            await contexto.AdicionarNota(nota2);

            var resultado = await contexto.GetAll();

            Assert.NotNull(resultado);
            Assert.Equal(2, resultado.Count);
            Assert.Contains(resultado, n => n.Titulo == "Teste 1" && n.Conteudo == "Conteúdo de teste 1");
            Assert.Contains(resultado, n => n.Titulo == "Teste 2" && n.Conteudo == "Conteúdo de teste 2");
        }
    }
}