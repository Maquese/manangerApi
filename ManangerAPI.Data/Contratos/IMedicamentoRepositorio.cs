using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IMedicamentoRepositorio : IRepositorio<Medicamento>
    {
        IList<Medicamento> ListarPorBeneficiario(int idBeneficiario); 
    }
}