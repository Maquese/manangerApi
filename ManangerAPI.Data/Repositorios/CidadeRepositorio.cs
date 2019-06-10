using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class CidadeRepositorio : Repositorio<Cidade>, ICidadeRepositorio
    {
        public CidadeRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<KeyValuePair<int, string>> GerarDropDown()
        {
            return _contexto.Cidade.Select(x => new KeyValuePair<int, string>(x.Id, x.Nome)).ToList();
        }

        public IList<KeyValuePair<int, string>> GerarDropDown(string uf)
        {
            var retorno = new List<KeyValuePair<int,string>>();
            retorno.Add(new KeyValuePair<int, string>(0,"Selecione"));
            retorno.AddRange(_contexto.Cidade.Where(x => x.Uf == uf).Select(x => new KeyValuePair<int, string>(x.Id, x.Nome)).ToList());
            return retorno;
        }
    }
}