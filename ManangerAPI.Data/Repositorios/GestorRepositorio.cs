using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class GestorRepositorio : Repositorio<Gestor>, IGestorRepositorio
    {
        public IList<Gestor> ListarNaoAnalisadosEReprovados()
        {
            return _contexto.Gestor.Where(x => (x.Aprovado == null || x.Aprovado) && x.StatusEntidadeId == 0).ToList();
        }

        public IList<Gestor> ListarPorAnalise(bool analisado)
        {
            return _contexto.Gestor.Where(x => x.Analisado == analisado && x.StatusEntidadeId == 0).ToList();
        }

        public IList<Gestor> ListarPorAprovacao(bool aprovado)
        {
             return _contexto.Gestor.Where(x => x.Aprovado == aprovado && x.StatusEntidadeId == 0).ToList();
        }
    }
}