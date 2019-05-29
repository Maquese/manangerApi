using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class MedicamentoRepositorio : Repositorio<Medicamento>, IMedicamentoRepositorio
    {
        public MedicamentoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<Medicamento> ListarPorBeneficiario(int idBeneficiario)
        {
            return _contexto.Medicamento.Where(x => x.BeneficiarioId == idBeneficiario && x.Status == 1).ToList();
        }
    }
}