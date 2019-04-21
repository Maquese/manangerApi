namespace ManangerAPI.Application.DTOS
{
    public class GestorDTO : UsuarioDTO
    {
        public string HistoricoProfissional { get; internal set; }
        public string CursosCertificacoes { get; internal set; }
    }
}