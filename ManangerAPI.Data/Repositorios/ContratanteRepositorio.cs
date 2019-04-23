using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class ContratanteRepositorio : Repositorio<Contratante>, IContratanteRepositorio
    {
        public ContratanteRepositorio()
        {            
        }

        public IList<Contratante> ListarNaoAnalisadosEReprovados()
        {
            return _contexto.Contratante.Where(x => (x.Aprovado == null || x.Aprovado) && x.StatusEntidadeId == 0).ToList();
        }

        public IList<Contratante> ListarPorAnalise(bool analisado)
        {
            return _contexto.Contratante.Where(x => x.Analisado == analisado && x.StatusEntidadeId == 0).ToList();
        }

        public IList<Contratante> ListarPorAprovacao(bool aprovado)
        {
              return _contexto.Contratante.Where(x => x.Aprovado == aprovado && x.StatusEntidadeId == 0).ToList();
        }
    }
}