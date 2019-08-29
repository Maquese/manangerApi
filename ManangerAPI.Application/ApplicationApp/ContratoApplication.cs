using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IContratoApplication
    {
        public IList<ContratoDTO> ListarContratosVigentesBeneficiario(int idBeneficiario)
        {
            return _contratoRepositorio.ListarContratoBeneficiario(idBeneficiario).Select(x => new ContratoDTO
            {
                 BeneficiarioId = x.BeneficiarioId,
                 PrestadorDeServicoId = x.PrestadorDeServicoId,
                 ContratanteId = x.ContratanteId,
                 DataFim = x.DataFim,
                 DataInicio = x.DataInicio,
                 NomeBeneficiario = _usuarioRepositorio.Encontrar(x.BeneficiarioId).Nome,
                 NomeContratante = _usuarioRepositorio.Encontrar(x.ContratanteId).Nome,
                 NomePrestadorDeServico = _usuarioRepositorio.Encontrar(x.PrestadorDeServicoId).Nome,
                 Id = x.Id,
                 DataSolicitacao = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).DataSolicitacao,
                 Comentario = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).Comentario,
                 SolicitacaoContratoId = x.SolicitacaoContratoId
            }).ToList();
        }

        public IList<ContratoDTO> ListarContratosVigentesContratante(int idContratante)
        {
            return _contratoRepositorio.ListarContratoContratante(idContratante).Select(x => new ContratoDTO
            {
                 BeneficiarioId = x.BeneficiarioId,
                 PrestadorDeServicoId = x.PrestadorDeServicoId,
                 ContratanteId = x.ContratanteId,
                 DataFim = x.DataFim,
                 DataInicio = x.DataInicio,
                 NomeBeneficiario = _usuarioRepositorio.Encontrar(x.BeneficiarioId).Nome,
                 NomeContratante = _usuarioRepositorio.Encontrar(x.ContratanteId).Nome,
                 NomePrestadorDeServico = _usuarioRepositorio.Encontrar(x.PrestadorDeServicoId).Nome,
                 Id = x.Id,
                 DataSolicitacao = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).DataSolicitacao,
                 Comentario = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).Comentario,
                 SolicitacaoContratoId = x.SolicitacaoContratoId
            }).ToList();
        }

        public IList<ContratoDTO> ListarContratosVigentesPrestadorDeServico(int idPrestdorDeServico)
        {
            return _contratoRepositorio.ListarContratoPrestador(idPrestdorDeServico).Select(x => new ContratoDTO
            {
                 BeneficiarioId = x.BeneficiarioId,
                 PrestadorDeServicoId = x.PrestadorDeServicoId,
                 ContratanteId = x.ContratanteId,
                 DataFim = x.DataFim,
                 DataInicio = x.DataInicio,
                 NomeBeneficiario = _usuarioRepositorio.Encontrar(x.BeneficiarioId).Nome,
                 NomeContratante = _usuarioRepositorio.Encontrar(x.ContratanteId).Nome,
                 NomePrestadorDeServico = _usuarioRepositorio.Encontrar(x.PrestadorDeServicoId).Nome,
                 Id = x.Id,
                 DataSolicitacao = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).DataSolicitacao,
                 Comentario = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).Comentario,
                 SolicitacaoContratoId = x.SolicitacaoContratoId
            }).ToList();
        }
    }
}