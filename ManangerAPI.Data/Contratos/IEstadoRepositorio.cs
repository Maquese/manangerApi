using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IEstadoRepositorio : IRepositorio<Estado>
    {
         IList<KeyValuePair<string,string>> GerarDropDown();
    }
}