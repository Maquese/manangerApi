using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IBeneficiarioMedicamentoRepositorio : IRepositorio<BeneficiarioMedicamento>
    {
         IList<BeneficiarioMedicamento> ListarPorBeneficiarioId(int idBeneficiario);
    }
}