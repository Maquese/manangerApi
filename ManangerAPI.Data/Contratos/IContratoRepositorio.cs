using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IContratoRepositorio : IRepositorio<Contrato>
    {
         IList<Contrato> ListarContratoPrestador(int prestadorId);
         IList<Contrato> ListarContratoBeneficiario(int beneficiarioId);

         IList<Contrato> ListarContratoContratante(int contratanteId);
         
         
    }
}