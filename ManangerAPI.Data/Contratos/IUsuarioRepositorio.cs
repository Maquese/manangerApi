using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
         Usuario Logar(string login, string senha);

         bool VerificaEmailJaCadastrado(string email);
         
         bool VerificaCpfJaCadastrado(string cfp);

         Usuario LogarGestor(string login, string senha);

         Usuario LogarPrestador(string login, string senha);

         bool VerificaMesmoLogin(string login);

    }
}