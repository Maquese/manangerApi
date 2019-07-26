namespace ManangerAPI.Application.Contratos
{
    public interface IDownloadApplication
    {
         byte[] BaixarCurriculoPorUsuario(int idUsuario);
    }
}