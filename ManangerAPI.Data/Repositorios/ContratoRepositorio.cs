using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class ContratoRepositorio : Repositorio<Contrato>, IContratoRepositorio
    {
        public ContratoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }
    }
}