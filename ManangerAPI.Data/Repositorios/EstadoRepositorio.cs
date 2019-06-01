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

        public IList<KeyValuePair<int, string>> GerarDropDown()
        {
            return _contexto.Estado.Select(x => new KeyValuePair<int, string>(x.Id, x.Nome)).ToList();
        }
    }
}