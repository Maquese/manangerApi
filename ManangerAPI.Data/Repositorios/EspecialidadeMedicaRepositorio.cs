using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class EspecialidadeMedicaRepositorio : Repositorio<EspecialidadeMedica>, IEspecialidadeMedicaRepositorio
    {
        public EspecialidadeMedicaRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<KeyValuePair<int, string>> GerarDropDown()
        {
            var retorno = new List<KeyValuePair<int,string>>();
            retorno.AddRange(_contexto.EspecialidadeMedica.Select(x => new KeyValuePair<int, string>(x.Id, x.Nome)).ToList());
            return retorno;
        }
    }
}