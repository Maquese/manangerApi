using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class PrestadorDeServicoRepositorio : Repositorio<PrestadorDeServico>, IPrestadorDeServicoRepositorio
    {
        public IList<PrestadorDeServico> ListarNaoAnalisadosEReprovados()
        {
            return _contexto.PrestadorDeServico.Where(x => (x.Aprovado == null || x.Aprovado) && x.StatusEntidadeId == 0).ToList();
        }

        public IList<PrestadorDeServico> ListarPorAnalise(bool analisado)
        {
            return _contexto.PrestadorDeServico.Where(x => x.Analisado == analisado && x.StatusEntidadeId == 0).ToList();
        }

        public IList<PrestadorDeServico> ListarPorAprovacao(bool aprovado)
        {
           return _contexto.PrestadorDeServico.Where(x => x.Aprovado == aprovado && x.StatusEntidadeId == 0).ToList();
        }
    }
}