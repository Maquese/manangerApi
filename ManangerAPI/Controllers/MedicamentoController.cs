using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{   
    [ApiController]
    public class MedicamentoController : ControllerBase
    {
        private readonly IMedicamentoApplication _medicamentoApplication;

        public MedicamentoController(IMedicamentoApplication medicamentoApplication)
        {
            _medicamentoApplication  = medicamentoApplication;
        }

        [Route("api/medicamento/cadastrar")]
        [HttpPost]
        public void Cadastrar(MedicamentoRequest request)
        {
            _medicamentoApplication.Cadastrar(request.Nome,request.ContraIndicacao,request.Bula,
                                              request.Indicacao, request.Tipo, request.ViaDeUso,request.EfeitoColateral);
        }      

        [Route("api/medicamento/editar")]
        [HttpPost]
        public void Editar(MedicamentoRequest request)
        {
            _medicamentoApplication.Editar(request.Id, request.Nome, request.ContraIndicacao, request.Bula,request.Indicacao,
                                           request.Tipo,request.ViaDeUso,request.EfeitoColateral);
        }

        [Route("api/medicamento/remover")]
        [HttpPost]
        public void Remover(BaseRequest request)
        {
            _medicamentoApplication.Remover(request.Id);
        }

        [Route("api/medicamento/listar")]
        [HttpPost]
        public IList<MedicamentoListaDTO> Listar()
        {
            return _medicamentoApplication.Listar();
        }

        [Route("api/medicamento/detalhar")]
        [HttpPost]
        public MedicamentoDTO Detalhar(BaseRequest request)
        {
            return  _medicamentoApplication.Detalhar(request.Id);
        }

    }
}