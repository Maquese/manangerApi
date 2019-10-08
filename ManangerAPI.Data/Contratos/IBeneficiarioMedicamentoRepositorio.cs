using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IBeneficiarioMedicamentoRepositorio : IRepositorio<BeneficiarioMedicamento>
    {
         IList<BeneficiarioMedicamento> ListarPorBeneficiarioId(int idBeneficiario);

         BeneficiarioMedicamento EncontrarCompleto(int beneficiarioMedicamentoId);

         IList<KeyValuePair<int,string>> GerarDropDown(int beneficiarioId);

    }
}