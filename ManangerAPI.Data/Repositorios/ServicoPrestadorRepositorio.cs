using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class ServicoPrestadorRepositorio : Repositorio<ServicoPrestador>, IServicoPrestadorRepositorio
    {
        public ServicoPrestadorRepositorio(ContextoDb contexto) : base(contexto)
        {
        }
    }
}