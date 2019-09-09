using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class ContratoRepositorio : Repositorio<Contrato>, IContratoRepositorio
    {
        public ContratoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<Contrato> ListarContratoBeneficiario(int beneficiarioId)
        {
            return _contexto.Contrato.Where(x => x.BeneficiarioId == beneficiarioId && x.Status == 1 && (x.DataFim <= DateTime.Now || x.DataFim == null)).ToList();
        }

        public IList<Contrato> ListarContratoContratante(int contratanteId)
        {
            return _contexto.Contrato.Where(x => x.ContratanteId == contratanteId && x.Status == 1 && (x.DataFim <= DateTime.Now || x.DataFim == null)).ToList();
        }

        public IList<Contrato> ListarContratoPrestador(int prestadorId)
        {
            return _contexto.Contrato.Where(x => x.PrestadorDeServicoId == prestadorId && x.Status == 1 && (x.DataFim <= DateTime.Now || x.DataFim == null)).ToList();
        }
    }
}