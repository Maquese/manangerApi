using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IBeneficiarioRepositorio : IRepositorio<Beneficiario>
    {
         IList<Beneficiario> ListarPorContratante(int idContratante);
    }
}