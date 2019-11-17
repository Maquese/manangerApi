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
                                    TimeSpan horaFim, string corHexa, string comentario, bool todosOsDias, int? BeneficiarioMedicamentoId, int? QuantidadeMedicamento)
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
                BeneficiarioMedicamentoId = BeneficiarioMedicamentoId,
                QuantidadeMedicamento = QuantidadeMedicamento
            });
            _tarefaRepositorio.Save();

        }

        public void EditarTarefa(int tarefaId, string titulo, int contratoId, DateTime dataInicio, DateTime? dataFim, TimeSpan horaInicio, 
                                 TimeSpan horaFim, string corHexa, string comentario, bool todosOsDias, int? BeneficiarioMedicamentoId, int? QuantidadeMedicamento)
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
            tarefa.BeneficiarioMedicamentoId = BeneficiarioMedicamentoId;
            tarefa.QuantidadeMedicamento = QuantidadeMedicamento;
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
                HoraInicioString = x.HoraInicio.ToString().Substring(0,x.HoraInicio.ToString().Length - 3),
                HoraFimString = x.HoraFim.ToString().Substring(0,x.HoraFim.ToString().Length - 3),
                Comentario = x.Comentario,
                CorHexa = x.CorHexa,
                Id = x.Id,
                NomeMedicamento = x.BeneficiarioMedicamentoId.HasValue ? _medicamentoRepositorio.Encontrar(_beneficiarioMedicamentoRepositorio.Encontrar(x.BeneficiarioMedicamentoId.Value).MedicamentoId).Nome : "",
                QuantidadeMedicamento = x.QuantidadeMedicamento,
                BeneficiarioMedicamentoId = x.BeneficiarioMedicamentoId,
                TarefaRealizadaId =  x.TarefasRealizada.Where(y => y.Data.Date == dia).FirstOrDefault() == null ? 0 : x.TarefasRealizada.Where(y => y.Data.Date == dia).FirstOrDefault().Id,
                TarefaRealizada = x.TarefasRealizada.Where(y => y.Data.Date == dia).FirstOrDefault() == null ? null : x.TarefasRealizada.Where(y => y.Data.Date == dia).FirstOrDefault().Realizada,
                ComentarioTarefaRealizada = x.TarefasRealizada.Where(y => y.Data.Date == dia).FirstOrDefault() == null ? "" : x.TarefasRealizada.Where(y => y.Data.Date == dia).FirstOrDefault().Comentario,
            
                
            }).ToList();
        }
        public IList<TarefaDTO> ListarTarefasPorBeneficiario(int beneficiarioId, DateTime dataInicio, DateTime dataFim)
        {
            var retorno = new  List<TarefaDTO>();   
            var dados = _tarefaRepositorio.ListarTarefasPorBeneficiario(beneficiarioId,dataInicio,dataFim);

            while (dataInicio <= dataFim)
            {
                foreach (var item in dados.Where(x => (x.TodosOsDias && x.DataInicio.Date <= dataInicio.Date ) || (x.DataInicio.Date <= dataInicio.Date && (x.DataFim == null || x.DataFim.Value.Date >= dataInicio.Date))))
                {
                    retorno.Add(new TarefaDTO {
                         ContratoId = item.ContratoId,
                         Titulo = item.Titulo,
                         HoraInicio = item.HoraInicio,
                         HoraFim = item.HoraFim,
                         Comentario = item.Comentario,
                         CorHexa = item.CorHexa,
                         Data = dataInicio,
                         TarefaRealizadaId =  item.TarefasRealizada.Where(y => y.Data.Date == dataInicio.Date).FirstOrDefault() == null ? 0 : item.TarefasRealizada.Where(y => y.Data.Date == dataInicio.Date).FirstOrDefault().Id,
                         DataString = dataInicio.Date.ToString(),                         
                         TarefaRealizada = item.TarefasRealizada.Where(y => y.Data.Date == dataInicio.Date).FirstOrDefault() == null ? null : item.TarefasRealizada.Where(y => y.Data.Date == dataInicio.Date).FirstOrDefault().Realizada,
                         Id = item.Id,
                         QuantidadeMedicamento = item.QuantidadeMedicamento,
                         BeneficiarioMedicamentoId = item.BeneficiarioMedicamentoId,
                         NomeMedicamento = item.BeneficiarioMedicamentoId.HasValue ? _medicamentoRepositorio.Encontrar(_beneficiarioMedicamentoRepositorio.Encontrar(item.BeneficiarioMedicamentoId.Value).MedicamentoId).Nome : "",
                         DataInicio = item.DataInicio,
                         DataFim = item.DataFim,
                         TodosOsDias = item.TodosOsDias
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
                QuantidadeMedicamento = x.QuantidadeMedicamento,
                BeneficiarioMedicamentoId = x.BeneficiarioMedicamentoId
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
                TarefaRealizadaId =  x.TarefasRealizada.Where(y => y.Data == dia).FirstOrDefault() == null ? 0 : x.TarefasRealizada.Where(y => y.Data == dia).FirstOrDefault().Id,
                TarefaRealizada = x.TarefasRealizada.Where(y => y.Data == dia).FirstOrDefault() == null ? null : x.TarefasRealizada.Where(y => y.Data == dia).FirstOrDefault().Realizada,
                Id = x.Id,
                NomeMedicamento = x.BeneficiarioMedicamentoId.HasValue ? _medicamentoRepositorio.Encontrar(_beneficiarioMedicamentoRepositorio.Encontrar(x.BeneficiarioMedicamentoId.Value).MedicamentoId).Nome : "",
                QuantidadeMedicamento = x.QuantidadeMedicamento,
                BeneficiarioMedicamentoId = x.BeneficiarioMedicamentoId,
                ComentarioTarefaRealizada = x.TarefasRealizada.Where(y => y.Data == dia).FirstOrDefault() == null ? "" : x.TarefasRealizada.Where(y => y.Data == dia).FirstOrDefault().Comentario,
            }).ToList();
        }

        public void RemoverTarefa(int tarefaId)
        {
            var tarefa = _tarefaRepositorio.Encontrar(tarefaId);
            tarefa.Status  = (int)StatusEnum.Inativo;
            _tarefaRepositorio.Save();
        }

        public void TarefaRealizada(int tarefaId, string comentario, DateTime data, TimeSpan hora, bool realizada,int? tarefaRealizadaId)
        {

            var tarefa = _tarefaRepositorio.Encontrar(tarefaId);
            if(tarefa.BeneficiarioMedicamentoId != null && tarefa.BeneficiarioMedicamentoId != 0)
            {
                var medicamento = _beneficiarioMedicamentoRepositorio.Encontrar(tarefa.BeneficiarioMedicamentoId.Value);
                medicamento.Quantidade -= tarefa.QuantidadeMedicamento.Value;
            }

            if(tarefaRealizadaId == null || tarefaRealizadaId == 0)
            {
            _tarefaRealizadaRepositorio.Insert(new TarefaRealizada
            {
                Status = (int)StatusEnum.Ativo,
                Comentario = comentario,
                Data = data,
                Hora = hora,
                TarefaId = tarefaId,
                Realizada = realizada
            });    
            }else{
                var tarefaRealizada = _tarefaRealizadaRepositorio.Encontrar(tarefaRealizadaId.Value);
                tarefaRealizada.Comentario = comentario;
                tarefaRealizada.Data = data;
                tarefaRealizada.Hora = hora;
                tarefaRealizada.Realizada = realizada;
            }       

            _tarefaRealizadaRepositorio.Save();
        }
    }
}