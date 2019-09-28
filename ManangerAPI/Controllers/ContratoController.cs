using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class ContratoController : ControllerBase
    {
        private readonly IContratoApplication _contratoApplication;

        public ContratoController(IContratoApplication contratoApplication)
        {
            _contratoApplication = contratoApplication;
        }

        [Route("api/contrato/listarcontratosvigentesprestador")]
        [HttpPost]
        public IList<ContratoDTO> ListarContratosVigentesPrestador(BaseRequest request)
        {
            return _contratoApplication.ListarContratosVigentesPrestadorDeServico(request.Id);   
        }

        [Route("api/contrato/listarcontratosvigentescontratante")]
        [HttpPost]
        public IList<ContratoDTO> ListarContratosVigentesContratante(BaseRequest request)
        {
            return _contratoApplication.ListarContratosVigentesContratante(request.Id);   
        }

        [Route("api/contrato/listarcontratosvigentesbeneficiario")]
        [HttpPost]
        public IList<ContratoDTO> ListarContratosVigentesBeneficiario(BaseRequest request)
        {
            return _contratoApplication.ListarContratosVigentesBeneficiario(request.Id);   
        }

        [Route("api/contrato/encerrarcontratoprestador")]
        [HttpPost]
        public void EncerrarContratoPrestador(QuebraDeContratoRequest request)
        {
            _contratoApplication.EncerrarContratoPrestador(request.Id,request.Comentario);
        }

        [Route("api/contrato/encerrarcontratocontratante")]
        [HttpPost]
        public void EncerrarContratoContratante(QuebraDeContratoRequest request)
        {
            _contratoApplication.EncerrarContratoContratante(request.Id,request.Comentario);
        }

        [Route("api/contrato/listarcontratosencerradosprestador")]
        [HttpPost]
        public IList<ContratoDTO> ListarContratosEncerradosPrestador(BaseRequest request)
        {
            return _contratoApplication.ListarContratosEncerradosPrestadorDeServico(request.Id);   
        }

        [Route("api/contrato/listarcontratosencerradoscontratante")]
        [HttpPost]
        public IList<ContratoDTO> ListarContratosEncerradosContratante(BaseRequest request)
        {
            return _contratoApplication.ListarContratosEncerradosContratante(request.Id);   
        }

        [Route("api/contrato/listarcontratosencerradosbeneficiario")]
        [HttpPost]
        public IList<ContratoDTO> ListarContratosEncerradosBeneficiario(BaseRequest request)
        {
            return _contratoApplication.ListarContratosEncerradosBeneficiario(request.Id);   
        }

    }
}