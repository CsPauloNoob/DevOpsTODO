namespace DevOpsTODO.Data.Modelos
{
    public class Nota
    {
        public string Titulo { get; set; }
        public string? Conteudo { get; set; }


        public override string ToString()
        {
            return $"{Titulo} \n {Conteudo}";
        }
    }
}
