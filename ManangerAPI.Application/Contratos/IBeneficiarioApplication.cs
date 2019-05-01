using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IBeneficiarioApplication
    {
         void Deletar(int Id);
         void Adicionar(int idContratante, string nome);
         IList<BeneficiarioDTO> ListarPorContratante(int idContratante);
         void Editar(int idBeneficiario, string nome);
         BeneficiarioDTO EncontrarPorId(int idBeneficiario);
    }
}