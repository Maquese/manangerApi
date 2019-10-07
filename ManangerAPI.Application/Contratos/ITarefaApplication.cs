using System;
using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface ITarefaApplication
    {
        void AdicionarTarefa(string titulo, int contratoId, DateTime dataInicio, DateTime? dataFim, TimeSpan horaInicio,
                              TimeSpan horaFim, string corHexa, string comentario, bool todosOsDias);
        void EditarTarefa(int tarefaId,string titulo, int contratoId, DateTime dataInicio, DateTime? dataFim, TimeSpan horaInicio,
                              TimeSpan horaFim, string corHexa, string comentario, bool todosOsDias);
        IList<TarefaDTO> ListarTarefasPorContrato(int contratoId);
        IList<TarefaDTO> ListarTarefasPorBeneficiario(int beneficiarioId,DateTime dataInicio, DateTime dataFim);        
        IList<TarefaDTO> ListarTarefasPorBeneficiario(int beneficiarioId,DateTime dia);
        IList<TarefaDTO> ListarTarefasPorPrestadorDeServico(int prestadorId,DateTime dia);
        void TarefaRealizada(int tarefaId,string comentario, DateTime data, TimeSpan hora);
        void RemoverTarefa(int tarefaId);
    }
}