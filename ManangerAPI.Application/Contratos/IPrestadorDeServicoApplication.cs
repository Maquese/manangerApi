using System;
using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IPrestadorDeServicoApplication
    {
         void Cadastrar(string nome, string login, string senha, string email, DateTime dataNascimento, int sexo, string cpf, string telefone,
                        int cidade, string estado, string bairro,string cep, string rua, string numero, string complemento, IList<int> competencias,
                        string comentario, bool termos, string imagem);
        IList<PrestadorDeServicoDTO> ListarPorAnalise(bool analisado); 

        IList<PrestadorDeServicoDTO> ListarNaoAnalisadosEAprovados();

         IList<PrestadorDeServicoDTO> ListarPorAprovacao(bool aprovado); 

        UsuarioEditDTO BuscarPrestadorPorId(int id);
    }
}