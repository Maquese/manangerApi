using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IContratoApplication
    {
         
        IList<ContratoDTO> ListarContratosVigentesContratante(int idContratante);
         IList<ContratoDTO> ListarContratosVigentesBeneficiario(int idBeneficiario); 
         IList<ContratoDTO> ListarContratosVigentesPrestadorDeServico(int idPrestdorDeServico);
         void EncerrarContratoPrestador(int contratoId, string comentario);
         
         void EncerrarContratoContratante(int contratoId, string comentario);
    }
}