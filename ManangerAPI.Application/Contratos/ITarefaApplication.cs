using System;
using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface ITarefaApplication
    {
         void AdicionarTarefa(string titulo, int contratoId, DateTime dataInicio, DateTime dataFim, TimeSpan horaInicio, TimeSpan horaFim);

        IList<TarefaDTO> ListarTarefasPorContrato(int contratoId);
    }
}