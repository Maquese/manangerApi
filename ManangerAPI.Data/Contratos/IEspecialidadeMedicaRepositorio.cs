using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IEspecialidadeMedicaRepositorio : IRepositorio<EspecialidadeMedica>
    {
         IList<KeyValuePair<int,string>> GerarDropDown();
    }
}