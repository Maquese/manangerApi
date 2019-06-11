using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class PrestadorDeServicoCompetenciaRepositorio : Repositorio<PrestadorDeServicoCompetencia>, IPrestadorDeServicoCompetenciaRepositorio
    {
        public PrestadorDeServicoCompetenciaRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<PrestadorDeServicoCompetencia> EncontrarPorPrestadorDeServicoId(int id)
        {
            return _contexto.PrestadorDeServicoCompetencia.Where(x => x.PrestadorDeServicoId == id && x.Status == 1).ToList();
        }
    }
}