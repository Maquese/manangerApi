using System;
using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IGestorApplication
    {
         void Cadastrar(string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,string cidade,string estado,string bairro,string cep,
                        string rua,string numero,string complemento, string historicoProfissional, string certificacoes);

        IList<GestorDTO> ListarPorAnalise(bool analisado);   

        IList<GestorDTO> ListarNaoAnalisadosEAprovados();

         IList<GestorDTO> ListarPorAprovacao(bool aprovado); 
    }
}