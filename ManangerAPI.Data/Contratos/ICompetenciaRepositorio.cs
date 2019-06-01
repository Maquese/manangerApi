using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface ICompetenciaRepositorio : IRepositorio<Competencia>
    {
        IList<KeyValuePair<int, string>> GerarDropDown();
    }
}