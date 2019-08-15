using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface ISolicitacaoContratoRepositorio : IRepositorio<SolicitacaoContrato>
    {
         
         IList<SolicitacaoContrato> ListarSolicitacoesPorPrestador(int idPrestador);
         
         IList<SolicitacaoContrato> ListarSolicitacoesPorBeneficiario(int idBeneficiario);
    }
}