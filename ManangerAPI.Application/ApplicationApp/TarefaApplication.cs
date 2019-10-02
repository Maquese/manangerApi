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
        public void AdicionarTarefa(string titulo, int contratoId, DateTime dataInicio, DateTime? dataFim, TimeSpan horaInicio, 
                                    TimeSpan horaFim, string corHexa, string comentario, bool todosOsDias)
        {
            _tarefaRepositorio.Insert(new Tarefa
            {
                Titulo = titulo,
                ContratoId = contratoId,
                DataInicio = dataInicio,
                DataFim = dataFim,
                HoraInicio = horaInicio,
                HoraFim = horaFim,
                Status = (int)StatusEnum.Ativo,
                CorHexa = corHexa,
                Comentario = comentario,
                TodosOsDias = todosOsDias
            });
            _tarefaRepositorio.Save();

        }

        public IList<TarefaDTO> ListarTarefasPorBeneficiario(int beneficiarioId, DateTime dia)
        {
            return _tarefaRepositorio.ListarTarefasPorBeneficiario(beneficiarioId,dia).Select(x => new TarefaDTO
            {
                ContratoId = x.ContratoId,
                Titulo = x.Titulo,
                HoraInicio = x.HoraInicio,
                HoraFim = x.HoraFim,
                Comentario = x.Comentario,
                CorHexa = x.CorHexa,
                Id = x.Id
            }).ToList();
        }
        public IList<TarefaDTO> ListarTarefasPorBeneficiario(int beneficiarioId, DateTime dataInicio, DateTime dataFim)
        {
            var retorno = new  List<TarefaDTO>();   
            var dados = _tarefaRepositorio.ListarTarefasPorBeneficiario(beneficiarioId,dataInicio,dataFim);

            while (dataInicio <= dataFim)
            {
                foreach (var item in dados.Where(x => x.TodosOsDias || (x.DataInicio <= dataInicio && x.DataFim >= dataInicio)))
                {
                    retorno.Add(new TarefaDTO {
                         ContratoId = item.ContratoId,
                         Titulo = item.Titulo,
                         HoraInicio = item.HoraInicio,
                         HoraFim = item.HoraFim,
                         Comentario = item.Comentario,
                         CorHexa = item.CorHexa,
                         Data = dataInicio,
                         DataString = dataInicio.Date.ToString(),
                        Id = item.Id,
                    });
                }
                dataInicio = dataInicio.AddDays(1);
            }
            return retorno;
        }

        public IList<TarefaDTO> ListarTarefasPorContrato(int contratoId)
        {
            return _tarefaRepositorio.ListarTarefasPorContrato(contratoId).Select(x => new TarefaDTO
            {
                ContratoId = x.ContratoId,
                Titulo = x.Titulo,
                HoraInicio = x.HoraInicio,
                HoraFim = x.HoraFim,
                Comentario = x.Comentario,
                CorHexa = x.CorHexa,
                Id = x.Id,
            }).ToList();
        }

        public IList<TarefaDTO> ListarTarefasPorPrestadorDeServico(int prestadorId, DateTime dia)
        {
           return _tarefaRepositorio.ListarTarefasPorPrestador(prestadorId,dia).Select(x => new TarefaDTO
            {
                ContratoId = x.ContratoId,
                Titulo = x.Titulo,
                HoraInicio = x.HoraInicio,
                HoraFim = x.HoraFim,
                Comentario = x.Comentario,
                CorHexa = x.CorHexa,
                Data = dia,
                Id = x.Id
            }).ToList();
        }
    }
}