using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface ICondicaoClinicaRepositorio : IRepositorio<CondicaoClinica>
    {
         IList<KeyValuePair<int,string>> GerarDropDown();
    }
}