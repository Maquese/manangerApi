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
            return _contexto.Tarefa.Include("TarefasRealizada").Where(x => x.BeneficiarioId == beneficiarioId && x.Status == 1 && (x.TodosOsDias || 
                                                                                                    (x.DataInicio <= dataInicio && x.DataFim <= dataFim || 
                                                                                                     x.DataInicio >= dataInicio && x.DataFim >= dataFim)
                                                                                                     || x.DataInicio >= dataInicio && x.DataFim <= dataFim)).ToList();
            
        }

        public IList<Tarefa> ListarTarefasPorBeneficiario(int beneficiarioId, DateTime data)
        {
            
            return _contexto.Tarefa.Include("TarefasRealizada").Where(x => x.BeneficiarioId == beneficiarioId && x.Status == 1 && (x.TodosOsDias && x.DataInicio.Date <= data.Date || x.DataInicio.Date <= data.Date && x.DataFim.Value.Date >= data.Date)).ToList();
        }

        // public IList<Tarefa> ListarTarefasPorContrato(int contratoId)
        // {
        //     return _contexto.Tarefa.Include("TarefasRealizada").Where(x => x.Status == 1 && x.ContratoId == contratoId).ToList();
        // }

        public IList<Tarefa> ListarTarefasPorPrestador(int contratoId, DateTime data)
        {
            var contrato = _contexto.Contrato.Where(x => x.Id == contratoId && x.Status == 1 ).Select(y => new  {y.Id, y.BeneficiarioId}).FirstOrDefault();

            var contratos = _contexto.Contrato.Where(x => x.BeneficiarioId == contrato.BeneficiarioId && x.Status == 1).Select(y => y.Id).ToList();

            return _contexto.Tarefa.Include("TarefasRealizada").Where(x => x.BeneficiarioId == contrato.BeneficiarioId  && x.Status == 1 && (x.TodosOsDias && x.DataInicio <= data  || x.DataInicio <= data && x.DataFim >= data)).ToList();
        }
    }
}