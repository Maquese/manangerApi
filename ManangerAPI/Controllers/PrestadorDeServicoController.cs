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
                                                     request.Numero,request.Complemento,request.Competencias,request.Comentario,request.Termos, 
                                                     request.Imagem,request.Curriculo);
        }

        [HttpPost]
        [Route("api/prestadordeservico/editar")]
        public void Editar(PrestadorDeServicoRequest request)
        {
            _prestadorDeServicoApplication.EditarPrestadorDeServico(request.Id,request.Nome,request.Login,request.Senha,request.Email,request.DataNascimento,request.Sexo,
                                                     request.Cpf,request.Telefone,request.Cidade,request.Estado,request.Bairro,request.Cep,request.Rua,
                                                     request.Numero,request.Complemento,request.Competencias,request.Comentario,request.Termos, 
                                                     request.Imagem,request.Curriculo);
        }

        [Route("api/prestadordeservico/buscar")]
        [HttpPost]
        public UsuarioEditDTO Buscar(BaseRequest request)
        {
            return _prestadorDeServicoApplication.BuscarPrestadorPorId(request.Id);
        }


        
        [Route("api/prestadordeservico/listarnaoaprovados")]
        [HttpPost]
        public IList<PrestadorDeServicoDTO> ListarNaoAprovados()
        {
            return _prestadorDeServicoApplication.ListarPorAprovacao(false);
        }

        [Route("api/gestor/listarprestadoresproximos")]
        [HttpPost]  
        public IList<ListagemPrestadorGestorDTO> ListarPrestadoresProximos(BaseRequest request)
        {
            return _prestadorDeServicoApplication.ListarPrestadoresProximos(request.Id);
        }

        

    }
}