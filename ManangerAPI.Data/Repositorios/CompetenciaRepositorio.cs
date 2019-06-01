using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class CompetenciaRepositorio : Repositorio<Competencia>, ICompetenciaRepositorio
    {
        public CompetenciaRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<KeyValuePair<int, string>> GerarDropDown()
        {
             return _contexto.Competencia.Select(x => new KeyValuePair<int, string>(x.Id, x.Nome)).ToList();
        }
    }
}