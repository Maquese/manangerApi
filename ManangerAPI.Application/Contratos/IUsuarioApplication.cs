using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IUsuarioApplication
    {
         IList<UsuarioDTO> ListarTodos();

         UsuarioDTO Logar(string login, string senha);

         UsuarioDTO LogarPrestador(string login, string senha);

         void Deletar(int id);

         void Analisar(int idUsuario, bool aprovado);

         DadosCadastraisDTO  BuscarDadosCadastrais(int idUsuario);

         UsuarioDTO BuscarDadosEmail(int idUsuario);

         bool VerificaEmailJaCadastrado(string email);

         bool VerificaCpfJaCadastrado(string cpf);

          bool VerificaLoginJaCadastrado(string login);
    }
}