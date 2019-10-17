using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IMedicoBeneficiarioRepositorio : IRepositorio<MedicoBeneficiario>
    {
         IList<MedicoBeneficiario> ListarPorBeneficiario(int idBenficiario);
    }
}