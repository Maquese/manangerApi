using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IContratoApplication
    {
         
        IList<ContratoDTO> ListarContratosVigentesContratante(int idContratante);
         IList<ContratoDTO> ListarContratosVigentesBeneficiario(int idBeneficiario); 
         IList<ContratoDTO> ListarContratosVigentesPrestadorDeServico(int idPrestdorDeServico);
    }
}