using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaApplication _tarefaApplication;

        public TarefaController(ITarefaApplication tarefaApplication)
        {
            _tarefaApplication = tarefaApplication;
        }

        [Route("api/tarefa/adicionar")]
        [HttpPost]
        public void Adicionar(TarefaRequest request)
        {
            _tarefaApplication.AdicionarTarefa(request.Titulo,request.ContratoId,request.DataInicio,request.DataFim,request.HoraInicio, request.HoraFim, 
                                               request.CorHexa,request.Comentario,request.TodosOsDias,request.BeneficiarioMedicamentoId,request.QuantidadeMedicamento);
        }

        [Route("api/tarefa/editar")]
        [HttpPost]
        public void Editar(TarefaRequest request)
        {
            _tarefaApplication.EditarTarefa(request.Id,request.Titulo,request.ContratoId,request.DataInicio,request.DataFim,request.HoraInicio, request.HoraFim,
                                            request.CorHexa,request.Comentario,request.TodosOsDias,request.BeneficiarioMedicamentoId,request.QuantidadeMedicamento);
        }

        [Route("api/tarefa/listartarefasporcontrato")]
        [HttpPost]
        public IList<TarefaDTO> ListarTarefasPorContrato(BaseRequest request)
        {
            return _tarefaApplication.ListarTarefasPorContrato(request.Id);
        }

        [Route("api/tarefa/listartodastarefasbeneficiarios")]
        [HttpPost]
        public IList<TarefaDTO> ListarTodasTarefasBeneficiarios(TarefaRequest request)
        {
            return _tarefaApplication.ListarTarefasPorBeneficiario(request.Id,request.DataInicio, request.DataFim.Value);
        }

        [Route("api/tarefa/listartodastarefasbeneficiariospordia")]
        [HttpPost]
        public IList<TarefaDTO> ListarTodasTarefasBeneficiariosPorDia(TarefaRequest request)
        {
            return _tarefaApplication.ListarTarefasPorBeneficiario(request.Id, request.Data);
        }

        [Route("api/tarefa/listartodastarefasprestadorpordia")]
        [HttpPost]
        public IList<TarefaDTO> ListarTodasTarefasPrestadorPorDia(TarefaRequest request)
        {
            return _tarefaApplication.ListarTarefasPorPrestadorDeServico(request.Id, request.Data);
        }

        [Route("api/tarefa/realizartarefa")]
        [HttpPost]
        public void RealizarTarefa(TarefaRealizadaRequest request)
        {
            _tarefaApplication.TarefaRealizada(request.TarefaId,request.Comentario,request.Data,request.Hora);
        }


    }
}