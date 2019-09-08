using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class TarefaRepositorio : Repositorio<Tarefa>, ITarefaRepositorio
    {
        public TarefaRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<Tarefa> ListarTarefasPorContrato(int contratoId)
        {
            return _contexto.Tarefa.Where(x => x.Status == 1 && x.ContratoId == contratoId).ToList();
        }
    }
}