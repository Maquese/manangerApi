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
            _beneficiarioApplication.AdicionarMedicamento(request.BeneficiarioId,request.MedicamentoId,request.PosologiaId,request.Quantidade,request.DataInicio,request.DataFim);
        }

        [HttpPost]
        [Route("api/beneficiario/listarmedicamento")]
        public IList<BeneficiarioMedicamentoListaDTO> ListarMedicamento(BaseRequest request)
        {
            return _beneficiarioApplication.ListarBeneficiarioMedicamento(request.Id);
        }

        [HttpPost]
        [Route("api/beneficiario/detalhesmedicamento")]
        public BeneficiarioMedicamentoDTO DetalhesMedicamento(BaseRequest request)
        {
            return _beneficiarioApplication.DetalharBeneficiarioMedicamento(request.Id);
        }

        [HttpPost]
        [Route("api/beneficiario/editarmedicamento")]
        public void EditarMedicamento(BeneficiarioMedicamentoRequest request)
        {
            _beneficiarioApplication.EditarBeneficiarioMedicamento(request.Id,request.MedicamentoId,request.PosologiaId,request.Quantidade);
        }

        [HttpPost]
        [Route("api/beneficiario/removermedicamento")]
        public void RemoverMedicamento(BaseRequest request)
        {
            _beneficiarioApplication.RemoverBeneficiarioMedicamento(request.Id);
        }

        [HttpPost]
        [Route("api/beneficiario/listarsolicitacoespendentes")]
        public IList<SolicitacaoPendenteDTO> ListarSolicitacoesPendentes(BaseRequest request)
        {
            return _beneficiarioApplication.ListarSolicitacoesPendentes(request.Id);
        }

        [HttpPost]
        [Route("api/beneficiario/cancelarsolicitacaocontrato")]
        public void CancelarSolicitacaoContrato(BaseRequest request)
        {
            _beneficiarioApplication.CancelarSolicitacaoContrato(request.Id);
        }        
    }
}