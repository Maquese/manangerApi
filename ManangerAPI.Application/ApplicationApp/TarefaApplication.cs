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
                TodosOsDias = todosOsDias,
            });
            _tarefaRepositorio.Save();

        }

        public void EditarTarefa(int tarefaId, string titulo, int contratoId, DateTime dataInicio, DateTime? dataFim, TimeSpan horaInicio, TimeSpan horaFim, string corHexa, string comentario, bool todosOsDias)
        {
            var tarefa = _tarefaRepositorio.Encontrar(tarefaId);
            tarefa.Titulo = titulo;
            tarefa.ContratoId = contratoId;
            tarefa.DataInicio = dataInicio;
            tarefa.DataFim = dataFim;
            tarefa.HoraInicio = horaInicio;
            tarefa.HoraFim = horaFim;
            tarefa.Status = (int)StatusEnum.Ativo;
            tarefa.CorHexa = corHexa;
            tarefa.Comentario = comentario;
            tarefa.TodosOsDias = todosOsDias;
            _tarefaRepositorio.Update(tarefa);
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
                         TarefaRealizada = item.TarefasRealizada.Where(x => x.Data == dataInicio).FirstOrDefault() != null,
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

        public IList<TarefaDTO> ListarTarefasPorPrestadorDeServico(int contratoId, DateTime dia)
        {
           return _tarefaRepositorio.ListarTarefasPorPrestador(contratoId,dia).Select(x => new TarefaDTO
            {
                ContratoId = x.ContratoId,
                Titulo = x.Titulo,
                HoraInicio = x.HoraInicio,
                HoraFim = x.HoraFim,
                Comentario = x.Comentario,
                CorHexa = x.CorHexa,
                Data = dia,
                TarefaRealizada = x.TarefasRealizada.Where(y => y.Data == dia).FirstOrDefault() != null,
                Id = x.Id
            }).ToList();
        }

        public void RemoverTarefa(int tarefaId)
        {
            var tarefa = _tarefaRepositorio.Encontrar(tarefaId);
            tarefa.Status  = (int)StatusEnum.Inativo;
            _tarefaRepositorio.Save();
        }

        public void TarefaRealizada(int tarefaId, string comentario, DateTime data, TimeSpan hora)
        {
            _tarefaRealizadaRepositorio.Insert(new Data.Entidades.TarefaRealizada
            {
                Status = 1,
                Comentario = comentario,
                Data = data,
                Hora = hora,
                TarefaId = tarefaId
            });

            _tarefaRealizadaRepositorio.Save();
        }
    }
}