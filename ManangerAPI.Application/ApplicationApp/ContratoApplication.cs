using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Application.Enums;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IContratoApplication
    {
        public void AvaliarContratoContratante(int contratoId,string comentario, double avaliacao)
        {
            var contrato  = _contratoRepositorio.Encontrar(contratoId);
            contrato.AvaliacaoPrestador = avaliacao;
            contrato.ComentarioEncerramentoPrestador = comentario;
            _contratoRepositorio.Save();
        }

        public void AvaliarContratoPrestador(int contratoId,string comentario, double avaliacao)
        {
            var contrato  = _contratoRepositorio.Encontrar(contratoId);
            contrato.AvaliacaoContratante = avaliacao;
            contrato.ComentarioEncerramentoContratante = comentario;
            _contratoRepositorio.Save();
        }

        public void EncerrarContratoContratante(int contratoId, string comentario, double avaliacao)
        {
            var contrato = _contratoRepositorio.Encontrar(contratoId);
            contrato.DataFim = DateTime.Now;
            contrato.ComentarioEncerramentoContratante = comentario;
            contrato.EncerradoPorContratante = true;
            contrato.Status = (int)StatusEnum.Inativo;
            contrato.AvaliacaoPrestador = avaliacao;
            _contratoRepositorio.Save();
        }

        public void EncerrarContratoPrestador(int contratoId, string comentario,double avaliacao)
        {            
            var contrato = _contratoRepositorio.Encontrar(contratoId);
            contrato.DataFim = DateTime.Now;
            contrato.ComentarioEncerramentoPrestador = comentario;
            contrato.EncerradoPorContratante = false;
            contrato.AvaliacaoContratante = avaliacao;
            contrato.Status = (int)StatusEnum.Inativo;
            _contratoRepositorio.Save();
        }

        public IList<ContratoDTO> ListarContratosEncerradosBeneficiario(int idBeneficiario)
        {
            return _contratoRepositorio.ListarContratoEncerradosBeneficiario(idBeneficiario).Select(x => new ContratoDTO
            {
                 BeneficiarioId = x.BeneficiarioId,
                 PrestadorDeServicoId = x.PrestadorDeServicoId,
                 ContratanteId = x.ContratanteId,
                 DataFim = x.DataFim,
                 DataInicio = x.DataInicio,
                 NomeBeneficiario = _beneficiarioRepositorio.Encontrar(x.BeneficiarioId).Nome,
                 NomeContratante = _usuarioRepositorio.Encontrar(x.ContratanteId).Nome,
                 NomePrestadorDeServico = _usuarioRepositorio.Encontrar(x.PrestadorDeServicoId).Nome,
                 Id = x.Id,
                 DataSolicitacao = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).DataSolicitacao,
                 Comentario = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).Comentario,
                 SolicitacaoContratoId = x.SolicitacaoContratoId,
                 TelefoneContratante = _contratanteRepositorio.Encontrar(x.ContratanteId).Telefone,
                 TelefonePrestador = _prestadorDeServicoRepositorio.Encontrar(x.PrestadorDeServicoId).Telefone,
                 ComentarioEncerramentoPrestador = x.ComentarioEncerramentoPrestador,
                 ComentarioEncerramentoContratante = x.ComentarioEncerramentoContratante
            }).ToList();
        }

        public IList<ContratoDTO> ListarContratosEncerradosContratante(int idContratante)
        {
             return _contratoRepositorio.ListarContratoEncerradosContratante(idContratante).Select(x => new ContratoDTO
            {
                 BeneficiarioId = x.BeneficiarioId,
                 PrestadorDeServicoId = x.PrestadorDeServicoId,
                 ContratanteId = x.ContratanteId,
                 DataFim = x.DataFim,
                 DataInicio = x.DataInicio,
                 NomeBeneficiario = _beneficiarioRepositorio.Encontrar(x.BeneficiarioId).Nome,
                 NomeContratante = _usuarioRepositorio.Encontrar(x.ContratanteId).Nome,
                 NomePrestadorDeServico = _usuarioRepositorio.Encontrar(x.PrestadorDeServicoId).Nome,
                 Id = x.Id,
                 DataSolicitacao = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).DataSolicitacao,
                 Comentario = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).Comentario,
                 SolicitacaoContratoId = x.SolicitacaoContratoId,
                 TelefoneContratante = _contratanteRepositorio.Encontrar(x.ContratanteId).Telefone,
                 TelefonePrestador = _prestadorDeServicoRepositorio.Encontrar(x.PrestadorDeServicoId).Telefone,
                 ComentarioEncerramentoPrestador = x.ComentarioEncerramentoPrestador,
                 ComentarioEncerramentoContratante = x.ComentarioEncerramentoContratante
            }).ToList();
        }

        public IList<ContratoDTO> ListarContratosEncerradosPrestadorDeServico(int idPrestdorDeServico)
        {
             return _contratoRepositorio.ListarContratoEncerradosPrestador(idPrestdorDeServico).Select(x => new ContratoDTO
            {
                 BeneficiarioId = x.BeneficiarioId,
                 PrestadorDeServicoId = x.PrestadorDeServicoId,
                 ContratanteId = x.ContratanteId,
                 DataFim = x.DataFim,
                 DataInicio = x.DataInicio,
                 NomeBeneficiario = _beneficiarioRepositorio.Encontrar(x.BeneficiarioId).Nome,
                 NomeContratante = _usuarioRepositorio.Encontrar(x.ContratanteId).Nome,
                 NomePrestadorDeServico = _usuarioRepositorio.Encontrar(x.PrestadorDeServicoId).Nome,
                 Id = x.Id,
                 DataSolicitacao = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).DataSolicitacao,
                 Comentario = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).Comentario,
                 SolicitacaoContratoId = x.SolicitacaoContratoId,
                 TelefoneContratante = _contratanteRepositorio.Encontrar(x.ContratanteId).Telefone,
                 TelefonePrestador = _prestadorDeServicoRepositorio.Encontrar(x.PrestadorDeServicoId).Telefone,
                 ComentarioEncerramentoPrestador = x.ComentarioEncerramentoPrestador,
                 ComentarioEncerramentoContratante = x.ComentarioEncerramentoContratante
            }).ToList();
        }

        public IList<ContratoDTO> ListarContratosVigentesBeneficiario(int idBeneficiario)
        {
            return _contratoRepositorio.ListarContratoBeneficiario(idBeneficiario).Select(x => new ContratoDTO
            {
                 BeneficiarioId = x.BeneficiarioId,
                 PrestadorDeServicoId = x.PrestadorDeServicoId,
                 ContratanteId = x.ContratanteId,
                 DataFim = x.DataFim,
                 DataInicio = x.DataInicio,
                 NomeBeneficiario = _beneficiarioRepositorio.Encontrar(x.BeneficiarioId).Nome,
                 NomeContratante = _usuarioRepositorio.Encontrar(x.ContratanteId).Nome,
                 NomePrestadorDeServico = _usuarioRepositorio.Encontrar(x.PrestadorDeServicoId).Nome,
                 Id = x.Id,
                 DataSolicitacao = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).DataSolicitacao,
                 Comentario = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).Comentario,
                 SolicitacaoContratoId = x.SolicitacaoContratoId,
                 TelefoneContratante = _contratanteRepositorio.Encontrar(x.ContratanteId).Telefone,
                 TelefonePrestador = _prestadorDeServicoRepositorio.Encontrar(x.PrestadorDeServicoId).Telefone
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
                 NomeBeneficiario = _beneficiarioRepositorio.Encontrar(x.BeneficiarioId).Nome,
                 NomeContratante = _usuarioRepositorio.Encontrar(x.ContratanteId).Nome,
                 NomePrestadorDeServico = _usuarioRepositorio.Encontrar(x.PrestadorDeServicoId).Nome,
                 Id = x.Id,
                 DataSolicitacao = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).DataSolicitacao,
                 Comentario = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).Comentario,
                 SolicitacaoContratoId = x.SolicitacaoContratoId,
                 TelefoneContratante = _contratanteRepositorio.Encontrar(x.ContratanteId).Telefone,
                 TelefonePrestador = _prestadorDeServicoRepositorio.Encontrar(x.PrestadorDeServicoId).Telefone
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
                 NomeBeneficiario = _beneficiarioRepositorio.Encontrar(x.BeneficiarioId).Nome,
                 NomeContratante = _usuarioRepositorio.Encontrar(x.ContratanteId).Nome,
                 NomePrestadorDeServico = _usuarioRepositorio.Encontrar(x.PrestadorDeServicoId).Nome,
                 Id = x.Id,
                 DataSolicitacao = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).DataSolicitacao,
                 Comentario = _solicitacaoContratoRepositorio.Encontrar(x.SolicitacaoContratoId).Comentario,
                 SolicitacaoContratoId = x.SolicitacaoContratoId,
                 SexoNome = ((SexoEnum)_beneficiarioRepositorio.Encontrar(x.BeneficiarioId).Sexo).ToString(),
                 BeneficiarioDataNascimento = _beneficiarioRepositorio.Encontrar(x.BeneficiarioId).DataNascimento,
                 BeneficiarioBairro = _beneficiarioRepositorio.Encontrar(x.BeneficiarioId).Bairro,
                 TelefoneContratante = _contratanteRepositorio.Encontrar(x.ContratanteId).Telefone,
                 TelefonePrestador = _prestadorDeServicoRepositorio.Encontrar(x.PrestadorDeServicoId).Telefone
                 
            }).ToList();
        }
    }
}