using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IContratanteApplication
    {
         void Cadastrar(string nome, string cpf, string cep);///entre outras coisas

         IList<ContratanteDTO> ListarContratantes(bool analisado);   

         ContratanteDTO DetalharContratante(int idContratante);      
    }
}