using System;
using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IContratanteApplication
    {
         void Cadastrar(string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,string cidade,string estado,string bairro,string cep,
                        string numero,string complemento, string rua);///entre outras coisas
         IList<ContratanteDTO> ListarContratantes(bool analisado);   

         ContratanteDTO DetalharContratante(int idContratante);      
    }
}