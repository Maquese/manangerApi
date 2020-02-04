namespace ManangerAPI.Data.Entidades
{
    public class Contato : EntidadeBase
    {
        public int TipoContatoId { get; set; }
        public virtual TipoContato TipoContato { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Comentario { get; set; }
    }
}