using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class UnidadeDeMedidaRepositorio : Repositorio<UnidadeDeMedida>, IUnidadeDeMedidaRepositorio
    {
        public UnidadeDeMedidaRepositorio(ContextoDb contexto) : base(contexto)
        {

        }

        public IList<KeyValuePair<int, string>> GerarDropDown()
        {
            var retorno = new List<KeyValuePair<int,string>>();
            retorno.Add(new KeyValuePair<int, string>(0,"Selecione"));
            retorno.AddRange(_contexto.UnidadeDeMedida.Select(x => new KeyValuePair<int, string>(x.Id, x.Nome)).ToList());
            return retorno;
        }
    }
}