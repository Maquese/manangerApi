using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IPrestadorDeServicoCompetenciaRepositorio : IRepositorio<PrestadorDeServicoCompetencia>
    {
         IList<PrestadorDeServicoCompetencia> EncontrarPorPrestadorDeServicoId(int id);
    }
}