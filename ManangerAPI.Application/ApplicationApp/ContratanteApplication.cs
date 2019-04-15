using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IContratanteApplication
    {
        public void Cadastrar(string nome, string cpf, string cep)
        {
            
        }

        public ContratanteDTO DetalharContratante(int idContratante)
        {
            throw new System.NotImplementedException();
        }

        public IList<ContratanteDTO> ListarContratantes(bool analisado)
        {
            throw new System.NotImplementedException();
        }
    }
}