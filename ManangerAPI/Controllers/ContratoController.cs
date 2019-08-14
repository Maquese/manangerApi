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

        [Route("api/contratante/buscardadossolicitacaocontratanteprestador")]
        [HttpPost]
        public DadosSolicitacaoContratoDTO BuscarDadosSolicitacaoContratantePrestador(SolicitacaoContratoRequest request)
        {
            return _contratoApplication.BuscarDadosSolicitacaoContrato(request.IdContratante,request.IdPrestadorDeServico,request.IdBeneficiario);   
        }
    }
}