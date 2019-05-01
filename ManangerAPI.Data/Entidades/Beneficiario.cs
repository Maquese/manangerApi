namespace ManangerAPI.Data.Entidades
{
    public class Beneficiario : EntidadeBase
    {
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; } 
    }
}