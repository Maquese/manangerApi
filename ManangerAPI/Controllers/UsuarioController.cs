using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _UsuarioApplication;

        public UsuarioController(IUsuarioApplication UsuarioApplication)
        {
            _UsuarioApplication = UsuarioApplication;
        }


        [Route("api/usuario/listartodos")]
        [HttpPost]
        public IList<UsuarioDTO> ListarTodos()
        {
            return _UsuarioApplication.ListarTodos();
        }

    }
}