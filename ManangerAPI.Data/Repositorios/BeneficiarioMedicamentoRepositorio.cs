using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class BeneficiarioMedicamentoRepositorio : Repositorio<BeneficiarioMedicamento>, IBeneficiarioMedicamentoRepositorio
    {
        public BeneficiarioMedicamentoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<BeneficiarioMedicamento> ListarPorBeneficiarioId(int idBeneficiario)
        {
            return _contexto.BeneficiarioMedicamento.Where(x => x.BeneficiarioId == idBeneficiario && x.Status == 1).ToList();
        }
    }
}