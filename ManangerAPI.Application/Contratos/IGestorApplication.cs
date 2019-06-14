using System;
using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IGestorApplication
    {
         void CadastrarGestor(string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,int cidade,string estado,string bairro,string cep,
                        string rua,string numero,string complemento, string curriculo, string imagem);

        void EditarGestor(int id, string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,int cidade,string estado,string bairro,string cep,
                        string rua,string numero,string complemento, string curriculo, string imagem);


        IList<GestorDTO> ListarPorAnalise(bool analisado);   

        IList<GestorDTO> ListarNaoAnalisadosEAprovados();

         IList<GestorDTO> ListarPorAprovacao(bool aprovado); 

         UsuarioEditDTO EncontrarGestorPorId(int id);

         IList<ListagemPrestadorGestorDTO> ListarGestoresProximos(int cidadeId);
    }
}