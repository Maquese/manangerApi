using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IUsuarioApplication
    {
         IList<UsuarioDTO> ListarTodos();

         UsuarioDTO Logar(string login, string senha);
    }
}