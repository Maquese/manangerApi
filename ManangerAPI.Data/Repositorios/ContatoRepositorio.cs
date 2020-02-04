using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class ContatoRepositorio : Repositorio<Contato>, IContatoRepositorio
    {
        public ContatoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }
    }
}