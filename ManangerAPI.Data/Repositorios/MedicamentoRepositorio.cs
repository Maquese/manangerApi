using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class MedicamentoRepositorio : Repositorio<Medicamento>, IMedicamentoRepositorio
    {
        public IList<Medicamento> ListarPorBeneficiario(int idBeneficiario)
        {
            return _contexto.Medicamento.Where(x => x.BeneficiarioId == idBeneficiario && x.Status == 1).ToList();
        }
    }
}