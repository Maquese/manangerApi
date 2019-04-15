using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
         Usuario Logar(string login, string senha);
    }
}