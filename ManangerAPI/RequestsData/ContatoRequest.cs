namespace ManangerAPI.RequestsData
{
    public class ContatoRequest : BaseRequest
    {
        public int TipoContato { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Comentario { get; set; }
        public string Observacao { get; set; }
    }
}