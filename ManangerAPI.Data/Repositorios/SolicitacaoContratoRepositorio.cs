using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;
using System;

namespace ManangerAPI.Data.Repositorios
{
    public class SolicitacaoContratoRepositorio : Repositorio<SolicitacaoContrato>, ISolicitacaoContratoRepositorio
    {
        public SolicitacaoContratoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<SolicitacaoContrato> ListarSolicitacoesPorBeneficiario(int idBeneficiario)
        {
            var y = _contexto.SolicitacaoContrato.Where(x => x.BeneficiarioId == idBeneficiario && x.Status == 1 && (x.DataFim >= DateTime.Now || x.DataFim == null)).ToList();
            return y;
            
        }

        public IList<SolicitacaoContrato> ListarSolicitacoesPorPrestador(int idPrestador)
        {
            return _contexto.SolicitacaoContrato.Where(x => x.PrestadorDeServicoId == idPrestador && x.Status == 1 && (x.DataFim >= DateTime.Now || x.DataFim == null)).ToList();
        }
    }
}