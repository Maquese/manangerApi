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


        #region Beneficiario
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

        #endregion 

        #region  Medicamento
        [HttpPost]
        [Route("api/beneficiario/adicionarmedicamento")]
        public void AdicionarMedicamento(BeneficiarioMedicamentoRequest request)
        {
            _beneficiarioApplication.AdicionarMedicamento(request.BeneficiarioId,request.MedicamentoId,request.PosologiaId,request.Quantidade, request.UnidadeDeMedida);
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
            _beneficiarioApplication.EditarBeneficiarioMedicamento(request.Id,request.MedicamentoId,request.PosologiaId,request.Quantidade, request.UnidadeDeMedida);
        }

        [HttpPost]
        [Route("api/beneficiario/removermedicamento")]
        public void RemoverMedicamento(BaseRequest request)
        {
            _beneficiarioApplication.RemoverBeneficiarioMedicamento(request.Id);
        }

        [HttpPost]
        [Route("api/beneficiario/entradamedicamento")]
        public void EntradaMedicamento(BeneficiarioMedicamentoRequest request)
        {
            _beneficiarioApplication.AdicionarQuantidadeMedicamento(request.Id,request.Quantidade);
        } 
        #endregion

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


        #region  Medicos 
        [HttpPost]
        [Route("api/beneficiario/inserirmedico")]
        public void InserirMedico(MedicoBeneficiarioRequest request)
        {
            _beneficiarioApplication.CadastrarNovoMedico(request.BeneficiarioId,request.Nome,request.TelefoneConsultorio,request.Celular,request.EspecialidadeMedicoId,
                                                         request.Convenio,request.Cep,request.Bairro,request.Rua, request.CidadeId,request.EstadoUf,request.Numero,request.Complemento);
        }  

        [Route("api/beneficiario/detalharmedico")]
        public MedicoBeneficiarioDTO DetalharMedico(BaseRequest request)
        {
            return _beneficiarioApplication.DetalharMedico(request.Id);    
        }  

        [Route("api/beneficiario/editarmedico")]
        public void EditarMedico(MedicoBeneficiarioRequest request)
        {
            _beneficiarioApplication.EditarNovoMedico(request.Id,request.Nome,request.TelefoneConsultorio,request.Celular,request.EspecialidadeMedicoId,
                                                         request.Convenio,request.Cep,request.Bairro,request.Rua, request.CidadeId,request.EstadoUf,request.Numero,request.Complemento);
        }

        [Route("api/beneficiario/removermedico")]
        public void RemoverMedico(BaseRequest request)
        {
            _beneficiarioApplication.RemoverMedico(request.Id);    
        } 

        [Route("api/beneficiario/listarmedico")]
        public IList<MedicoBeneficiarioDTO> ListarMedico(BaseRequest request)
        {
            return _beneficiarioApplication.ListarMedicosBenficiario(request.Id);    
        }  

        #endregion
        
                  
    }
}