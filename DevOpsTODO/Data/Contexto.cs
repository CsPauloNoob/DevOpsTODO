using DevOpsTODO.Data.Modelos;

namespace DevOpsTODO.Data
{
    public class Contexto
    {
        private List<Nota> Notas { get; set; } = new List<Nota>();


        public async Task<bool> AdicionarNota(Nota nota)
        {
            if (nota is null || string.IsNullOrEmpty(nota.Conteudo))
                return false;

            Notas.Add(nota);
            return await Task.FromResult(true);
        }

        public async Task<List<Nota>> GetAll()
        {
            return await Task.FromResult(Notas);
        }
    }
}
