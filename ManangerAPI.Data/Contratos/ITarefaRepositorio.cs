using System;
using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface ITarefaRepositorio : IRepositorio<Tarefa>
    {
         IList<Tarefa> ListarTarefasPorContrato(int contratoId);

         
         IList<Tarefa> ListarTarefasPorBeneficiario(int beneficiarioId);

         IList<Tarefa> ListarTarefasPorBeneficiario(int beneficiarioId, DateTime data);
         
         IList<Tarefa> ListarTarefasPorPrestador(int beneficiarioId, DateTime data);
    }
}