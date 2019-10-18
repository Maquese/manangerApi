using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IContratoApplication
    {
         
        IList<ContratoDTO> ListarContratosVigentesContratante(int idContratante);
         IList<ContratoDTO> ListarContratosVigentesBeneficiario(int idBeneficiario); 
         IList<ContratoDTO> ListarContratosVigentesPrestadorDeServico(int idPrestdorDeServico);

         IList<ContratoDTO> ListarContratosEncerradosContratante(int idContratante);
         IList<ContratoDTO> ListarContratosEncerradosBeneficiario(int idBeneficiario); 
         IList<ContratoDTO> ListarContratosEncerradosPrestadorDeServico(int idPrestdorDeServico);
         void EncerrarContratoPrestador(int contratoId, string comentario, double avaliacao);         
         void EncerrarContratoContratante(int contratoId, string comentario,double avaliacao);

         void AvaliarContratoContratante(int cotratoId,string comentario,double avaliacao);
         void AvaliarContratoPrestador(int cotratoId,string comentario,double avaliacao);

    }
}