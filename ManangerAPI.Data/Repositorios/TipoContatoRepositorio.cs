using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class TipoContatoRepositorio : Repositorio<TipoContato>, ITipoContatoRepositorio
    {
        public TipoContatoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }
    }
}