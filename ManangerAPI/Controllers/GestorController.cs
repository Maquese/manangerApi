using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{ 
    [ApiController]
    public class GestorController : ControllerBase
    {
        private readonly IGestorApplication _gestorApplication;

        public GestorController(IGestorApplication gestorApplication)
        {
            _gestorApplication = gestorApplication;
        }

      [HttpPost]
        [Route("api/gestor/cadastrar")]
        public void Cadastrar(GestorRequest request)
        {
            _gestorApplication.CadastrarGestor(request.Nome,request.Login,request.Senha,request.Email,request.DataNascimento,request.Sexo,request.Cpf,
                                         request.Telefone,request.Comentario,request.Termos,request.Cidade,request.Estado,request.Estado,request.Cep,
                                         request.Rua, request.Numero,request.Complemento,request.Curriculo, request.Imagem);
        }  

        [Route("api/gestor/listarnaoaprovados")]
        [HttpPost]  
        public IList<GestorDTO> ListarNaoAprovados()
        {
            return _gestorApplication.ListarPorAprovacao(false);
        }
    }
}