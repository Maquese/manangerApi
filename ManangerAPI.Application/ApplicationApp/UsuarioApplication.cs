using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IUsuarioApplication
    {
        public IList<UsuarioDTO> ListarTodos()
        {
            return _usuarioRepositorio.Listar().Select(x => new UsuarioDTO{Id = x.Id, Nome = x.Nome}).ToList();
        }
    }
}