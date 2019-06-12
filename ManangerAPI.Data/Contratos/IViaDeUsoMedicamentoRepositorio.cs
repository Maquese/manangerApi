using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IViaDeUsoMedicamentoRepositorio : IRepositorio<ViaDeUsoMedicamento>
    { 
         IList<KeyValuePair<int,string>> GerarDropDown();
    }
}