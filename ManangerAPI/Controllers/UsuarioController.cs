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
        private readonly IMailApplication _mailApplication;

        public UsuarioController(IUsuarioApplication UsuarioApplication, IMailApplication mailApplication)
        {
            _UsuarioApplication = UsuarioApplication;
            _mailApplication = mailApplication;
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

        [Route("api/usuario/logarprestador")]
        [HttpPost]
        public UsuarioDTO LogarPrestador(LoginRequest  request)
        {
            return _UsuarioApplication.LogarPrestador(request.Login,request.Senha);
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
            var dados = _UsuarioApplication.BuscarDadosEmail(request.Id);
            _mailApplication.EnviarEmailAnalise(request.Aprovado,dados.Email,dados.Nome);            
        }

        [Route("api/usuario/verificaremailcadastrado")]
        [HttpPost]
        public bool VerificarEmailCadastrado(VerificacaoRequest  request)
        {
           return _UsuarioApplication.VerificaEmailJaCadastrado(request.Email);   
        }

        [Route("api/usuario/verificarlogincadastrado")]
        [HttpPost]
        public bool VerificarLoginCadastrado(VerificacaoRequest  request)
        {
           return _UsuarioApplication.VerificaLoginJaCadastrado(request.Login); 
        }

        [Route("api/usuario/verificarcpfcadastrado")]
        [HttpPost]
        public bool VerificarCpfCadastrado(VerificacaoRequest  request)
        {
            return _UsuarioApplication.VerificaCpfJaCadastrado(request.Cpf);         
        }
    }
}