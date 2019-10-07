using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ManangerAPI.Data.Repositorios
{
    public class TarefaRepositorio : Repositorio<Tarefa>, ITarefaRepositorio
    {
        public TarefaRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<Tarefa> ListarTarefasPorBeneficiario(int beneficiarioId, DateTime dataInicio, DateTime dataFim)
        {
            var contratos = _contexto.Contrato.Where(x => x.BeneficiarioId == beneficiarioId && x.Status == 1 
                                                     && (x.DataFim <= DateTime.Now || x.DataFim == null)).Select(y => y.Id).ToList();
            return _contexto.Tarefa.Include("TarefaRealizada").Where(x => contratos.Contains(x.ContratoId) && x.Status == 1 && (x.TodosOsDias || 
                                                                                                    (x.DataInicio >= dataInicio && x.DataInicio <= dataFim || 
                                                                                                     x.DataFim >= dataInicio && x.DataFim <= dataFim))).ToList();
            
        }

        public IList<Tarefa> ListarTarefasPorBeneficiario(int beneficiarioId, DateTime data)
        {
            var contratos = _contexto.Contrato.Where(x => x.BeneficiarioId == beneficiarioId && x.Status == 1 
                                                     && (x.DataFim <= DateTime.Now || x.DataFim == null)).Select(y => y.Id).ToList();
            return _contexto.Tarefa.Include("TarefaRealizada").Where(x => contratos.Contains(x.ContratoId) && x.Status == 1 && (x.TodosOsDias || x.DataInicio <= data && x.DataFim >= data)).ToList();
        }

        public IList<Tarefa> ListarTarefasPorContrato(int contratoId)
        {
            return _contexto.Tarefa.Include("TarefaRealizada").Where(x => x.Status == 1 && x.ContratoId == contratoId).ToList();
        }

        public IList<Tarefa> ListarTarefasPorPrestador(int prestadorId, DateTime data)
        {
            var contratos = _contexto.Contrato.Where(x => x.PrestadorDeServicoId == prestadorId && x.Status == 1 
                                                     && (x.DataFim <= DateTime.Now || x.DataFim == null)).Select(y => y.Id).ToList();
            return _contexto.Tarefa.Include("TarefaRealizada").Where(x => contratos.Contains(x.ContratoId) && x.Status == 1 && (x.TodosOsDias || x.DataInicio <= data && x.DataFim >= data)).ToList();
        }
    }
}