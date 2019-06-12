using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly IBeneficiarioApplication _beneficiarioApplication;

        public BeneficiarioController(IBeneficiarioApplication beneficiarioApplication)
        {
            _beneficiarioApplication = beneficiarioApplication;
        }

        [HttpPost]
        [Route("api/beneficiario/adicionar")]
        public void Adicionar(BeneficiarioCriarRequest request)
        {
            _beneficiarioApplication.Adicionar(request.IdContratante,request.Nome, request.DataNascimento,request.Sexo,request.Telefone,
            request.Estado,request.Cidade,request.Bairro,request.Rua,request.Numero,request.Cep,request.Complemento,request.CondicoesClinicas,
            request.TermoDeResponsalidade);
        }

        [HttpPost]
        [Route("api/beneficiario/listarporcontratante")]
        public IList<BeneficiarioListaDTO> ListarPorContratante(BaseRequest request)
        {
            return _beneficiarioApplication.ListarPorContratante(request.Id);
        }

        [HttpPost]
        [Route("api/beneficiario/buscarporid")]
        public BeneficiarioDTO BuscarPorId(BaseRequest request)
        {
            return _beneficiarioApplication.EncontrarPorId(request.Id);
        }

        [HttpPost]
        [Route("api/beneficiario/editar")]
        public void Editar(BeneficiarioEditarRequest request)
        {
            _beneficiarioApplication.Editar(request.Id,request.Nome,request.DataNascimento,request.Sexo,request.Telefone,request.Estado,
                                                   request.Cidade,request.Bairro, request.Rua, request.Numero,request.Cep,request.Complemento,
                                                   request.CondicoesClinicas,request.TermoDeResponsalidade);
        }

        [HttpPost]
        [Route("api/beneficiario/adicionarmedicamento")]
        public void AdicionarMedicamento(BeneficiarioMedicamentoRequest request)
        {
            _beneficiarioApplication.AdicionarMedicamento(request.BeneficiarioId,request.MedicamentoId,request.PosologiaId,request.Quantidade);
        }
    }
}