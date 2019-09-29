using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class TarefaRealizadaRepositorio : Repositorio<TarefaRealizada>, ITarefaRealizadaRepositorio
    {
        public TarefaRealizadaRepositorio(ContextoDb contexto) : base(contexto)
        {
        }
    }
}