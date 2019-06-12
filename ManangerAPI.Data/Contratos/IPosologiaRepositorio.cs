using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IPosologiaRepositorio : IRepositorio<Posologia>
    {
         IList<KeyValuePair<int,string>> GerarDropDown();
    }
}