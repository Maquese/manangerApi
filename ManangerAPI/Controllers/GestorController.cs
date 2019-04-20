using ManangerAPI.Application.Contratos;
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
            _gestorApplication.Cadastrar(request.Nome,request.Login,request.Senha,request.Email,request.DataNascimento,request.Sexo,request.Cpf,
                                         request.Telefone,request.Comentario,request.Termos,request.Cidade,request.Estado,request.Estado,request.Cep,
                                         request.Rua, request.Numero,request.Complemento,request.Historico,request.Cursos);
        }
    }
}