using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class EstadoRepositorio : Repositorio<Estado>, IEstadoRepositorio
    {
        public EstadoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<KeyValuePair<string, string>> GerarDropDown()
        {
             var retorno = new List<KeyValuePair<string,string>>();
            retorno.Add(new KeyValuePair<string, string>("0","Selecione"));
            retorno.AddRange(_contexto.Estado.Select(x => new KeyValuePair<string, string>(x.Uf, x.Nome)).ToList());
            return retorno;
        }

        public int IdPorUf(string uf)
        {
            return _contexto.Estado.Where(x => x.Uf == uf).FirstOrDefault().Id;
        }
    }
}