using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface ITarefaRepositorio : IRepositorio<Tarefa>
    {
         IList<Tarefa> ListarTarefasPorContrato(int contratoId);
    }
}