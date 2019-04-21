using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class PrestadorDeServicoController : ControllerBase
    {
        private readonly IPrestadorDeServicoApplication _prestadorDeServicoApplication;

        public PrestadorDeServicoController(IPrestadorDeServicoApplication prestadorDeServicoApplication)
        {
            _prestadorDeServicoApplication = prestadorDeServicoApplication;
        }

        [HttpPost]
        [Route("api/prestadordeservico/cadastrar")]
        public void Cadastrar(PrestadorDeServicoRequest request)
        {
            _prestadorDeServicoApplication.Cadastrar(request.Nome,request.Login,request.Senha,request.Email,request.DataNascimento,request.Sexo,
                                                     request.Cpf,request.Telefone,request.Cidade,request.Estado,request.Bairro,request.Cep,request.Rua,
                                                     request.Numero,request.Complemento,request.Competencias,request.Comentario,request.Termos);
        }

        [Route("api/prestadordeservico/listarnaoaprovados")]
        [HttpPost]
        public IList<PrestadorDeServicoDTO> ListarNaoAprovados()
        {
            return _prestadorDeServicoApplication.ListarPorAprovacao(false);
        }
    }
}