using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IBeneficiarioApplication
    {
        public void Adicionar(int idContratante, string nome)
        {
            throw new System.NotImplementedException();
        }

        public void Editar(int idBeneficiario, string nome)
        {
            throw new System.NotImplementedException();
        }

        public BeneficiarioDTO EncontrarPorId(int idBeneficiario)
        {
            throw new System.NotImplementedException();
        }

        public IList<BeneficiarioDTO> ListarPorContratante(int idContratante)
        {
            throw new System.NotImplementedException();
        }
    }
}