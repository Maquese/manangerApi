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
            _tarefaApplication.AdicionarTarefa(request.Titulo,request.ContratoId,request.DataInicio,request.DataFim,request.HoraInicio, request.HoraFim);
        }

        [Route("api/tarefa/listartarefasporcontrato")]
        [HttpPost]
        public IList<TarefaDTO> ListarTarefasPorContrato(BaseRequest request)
        {
            return _tarefaApplication.ListarTarefasPorContrato(request.Id);
        }
    }
}