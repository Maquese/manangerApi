namespace ManangerAPI.Data.Entidades
{
    public class Endereco : EntidadeBase
    {
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}