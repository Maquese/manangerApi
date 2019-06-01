namespace ManangerAPI.Data.Entidades
{
    public class Estado  : EntidadeBase
    {
        public int CodigoUf { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public int Regiao { get; set; }
    }
}