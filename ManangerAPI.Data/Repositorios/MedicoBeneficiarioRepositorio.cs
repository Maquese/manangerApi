using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class MedicoBeneficiarioRepositorio : Repositorio<MedicoBeneficiario>, IMedicoBeneficiarioRepositorio
    {
        public MedicoBeneficiarioRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<MedicoBeneficiario> ListarPorBeneficiario(int idBenficiario)
        {
            return _contexto.MedicoBeneficiario.Where(x => x.BeneficiarioId == idBenficiario).ToList();
        }
    }
}