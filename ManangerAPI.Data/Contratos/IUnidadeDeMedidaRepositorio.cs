using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IUnidadeDeMedidaRepositorio : IRepositorio<UnidadeDeMedida>
    {
         IList<KeyValuePair<int, string>> GerarDropDown();
    }
}