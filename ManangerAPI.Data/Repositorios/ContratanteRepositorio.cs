using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class ContratanteRepositorio : Repositorio<Contratante>, IContratanteRepositorio
    {
        public ContratanteRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<Contratante> ListarNaoAnalisadosEReprovados()
        {
            return _contexto.Contratante.Where(x => x.Aprovado && x.Status == 1).ToList();
        }

        public IList<Contratante> ListarPorAnalise(bool analisado)
        {
            return _contexto.Contratante.Where(x => x.Analisado == analisado && x.Status == 1).ToList();
        }

        public IList<Contratante> ListarPorAprovacao(bool aprovado)
        {
              return _contexto.Contratante.Where(x => x.Aprovado == aprovado && x.Status == 1).ToList();
        }
    }
}