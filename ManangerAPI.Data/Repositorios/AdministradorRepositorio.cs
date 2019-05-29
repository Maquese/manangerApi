using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class AdministradorRepositorio : Repositorio<Administrador>, IAdministradorRepositorio
    {
        public AdministradorRepositorio(ContextoDb contexto) : base(contexto)
        {
        }
    }
}