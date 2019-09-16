using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Application.Enums;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : ITarefaApplication
    {
        public void AdicionarTarefa(string titulo, int contratoId, DateTime dataInicio, DateTime dataFim, TimeSpan horaInicio, TimeSpan horaFim)
        {
            _tarefaRepositorio.Insert(new Tarefa
            {
                Titulo = titulo,
                ContratoId = contratoId,
                DataInicio = dataInicio,
                DataFim = dataFim,
                HoraInicio = horaInicio,
                HoraFim = horaFim,
                Status = (int)StatusEnum.Ativo
            });
            _tarefaRepositorio.Save();

        }

        public IList<TarefaDTO> ListarTarefasPorBeneficiario(int beneficiarioId)
        {
            return _tarefaRepositorio.ListarTarefasPorBeneficiario(beneficiarioId).Select(x => new TarefaDTO
            {
                ContratoId = x.ContratoId,
                Titulo = x.Titulo,
                DataInicio = x.DataInicio,
                DataFim = x.DataFim,
                HoraInicio = x.HoraInicio,
                HoraFim = x.HoraFim,
                Comentario = x.Comentario,
                CorHexa = x.CorHexa,
                Id = x.Id,
                TodosOsDias = x.TodosOsDias
            }).ToList();
        }

        public IList<TarefaDTO> ListarTarefasPorContrato(int contratoId)
        {
            return _tarefaRepositorio.ListarTarefasPorContrato(contratoId).Select(x => new TarefaDTO
            {
                ContratoId = x.ContratoId,
                Titulo = x.Titulo,
                DataInicio = x.DataInicio,
                DataFim = x.DataFim,
                HoraInicio = x.HoraInicio,
                HoraFim = x.HoraFim,
                Comentario = x.Comentario,
                CorHexa = x.CorHexa,
                Id = x.Id,
                TodosOsDias = x.TodosOsDias
            }).ToList();
        }
    }
}