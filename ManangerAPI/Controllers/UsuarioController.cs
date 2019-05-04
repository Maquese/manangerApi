using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.RequestsData;
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

        [Route("api/usuario/dadoscadastrais")]
        [HttpPost]
        public DadosCadastraisDTO BuscarDadosCadastrais(BaseRequest request)
        {
            return _UsuarioApplication.BuscarDadosCadastrais(request.Id);
        }

        [Route("api/usuario/logar")]
        [HttpPost]
        public UsuarioDTO Logar(LoginRequest  request)
        {
            return _UsuarioApplication.Logar(request.Login,request.Senha);
        }

        [Route("api/usuario/deletar")]
        [HttpPost]
        public void Deletar(BaseRequest  request)
        {
            _UsuarioApplication.Deletar(request.Id);
        }

        [Route("api/usuario/analisar")]
        [HttpPost]
        public void Analisar(AnalisarRequest  request)
        {
            _UsuarioApplication.Analisar(request.Id,request.Aprovado);
        }

    }
}