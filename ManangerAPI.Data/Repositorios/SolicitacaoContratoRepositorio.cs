using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class SolicitacaoContratoRepositorio : Repositorio<SolicitacaoContrato>, ISolicitacaoContratoRepositorio
    {
        public SolicitacaoContratoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }
    }
}