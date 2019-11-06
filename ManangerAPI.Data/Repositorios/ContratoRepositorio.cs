using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ManangerAPI.Data.Repositorios
{
    public class ContratoRepositorio : Repositorio<Contrato>, IContratoRepositorio
    {
        public ContratoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<KeyValuePair<int, string>> GerarDropDown(int beneficiarioId)
        {
            var retorno = new List<KeyValuePair<int,string>>();
            retorno.Add(new KeyValuePair<int, string>(0,"Selecione"));
            retorno.AddRange(_contexto.Contrato.Include("PrestadorDeServico").Where(x => x.BeneficiarioId == beneficiarioId && 
                                                      x.Status == 1 && (x.DataFim <= DateTime.Now || x.DataFim == null))
                                               .Select(x => new KeyValuePair<int, string>(x.Id, x.PrestadorDeServico.Nome)).ToList());
            return retorno;
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

         public IList<Contrato> ListarContratoEncerradosBeneficiario(int beneficiarioId)
        {
            return _contexto.Contrato.Where(x => x.BeneficiarioId == beneficiarioId && x.Status == 2).ToList();
        }

        public IList<Contrato> ListarContratoEncerradosContratante(int contratanteId)
        {
            return _contexto.Contrato.Where(x => x.ContratanteId == contratanteId && x.Status == 2).ToList();
        }

        public IList<Contrato> ListarContratoEncerradosPrestador(int prestadorId)
        {
            return _contexto.Contrato.Where(x => x.PrestadorDeServicoId == prestadorId && x.Status == 2).ToList();
        }

        public IList<int> ListarContratosEncerradosUsuario(int perfil, int usuarioId)
        {
              if(perfil == 2)   
              {
                  return _contexto.Contrato.Where(x => x.ContratanteId == usuarioId && x.Status == 2 && !x.AvaliacaoContratante.HasValue).Select(x => x.Id).ToList();
              }else{
                  return _contexto.Contrato.Where(x => x.PrestadorDeServicoId == usuarioId && x.Status == 2 && x.AvaliacaoContratante.HasValue).Select(x => x.Id).ToList();
              }
        }
    }
}