using DevOpsTODO.Data.Modelos;

namespace DevOpsTODO.Testes
{
    public class NotaModelTest
    {
        [Fact]
        public void ChamarToString_DeveRetornarStringFormatadaDasPropriedades()
        {
            // Arrange
            var nota = new Nota
            {
                Titulo = "Teste",
                Conteudo = "Conteúdo de teste"
            };
            // Act
            var resultado = nota.ToString();
            // Assert
            Assert.Equal("Teste \n Conteúdo de teste", resultado);
        }
    }
}
