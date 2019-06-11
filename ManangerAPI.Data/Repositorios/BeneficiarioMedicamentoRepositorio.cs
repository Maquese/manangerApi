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
    }
}