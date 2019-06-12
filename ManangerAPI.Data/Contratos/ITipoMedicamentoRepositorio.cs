using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface ITipoMedicamentoRepositorio : IRepositorio<TipoMedicamento>
    {
         IList<KeyValuePair<int,string>> GerarDropDown();
    }
}