using System.Collections.Generic;
using System.Threading.Tasks;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class ContratanteController : ControllerBase
    {
        private readonly IContratanteApplication _contratanteApplication;

        public ContratanteController(IContratanteApplication contratanteApplication)
        {
            _contratanteApplication = contratanteApplication;
        }


        [Route("api/Contratante/Cadastrar")]
        [HttpPost]
        public void Cadastrar(ContratanteRequest contratante)
        {
            _contratanteApplication.Cadastrar(contratante.Nome,contratante.Login,contratante.Senha,contratante.Email,contratante.DataNascimento,
                                              contratante.Sexo, contratante.Cpf,contratante.Telefone,contratante.Comentario,contratante.Termos,
                                              contratante.Cidade,contratante.Estado,contratante.Bairro,contratante.Cep,contratante.Numero,contratante.Complemento,
                                              contratante.Rua, contratante.Imagem);
        }

        [Route("api/contratante/listarnaoanalidos")]
        [HttpPost]
        public IList<ContratanteDTO> ListarNaoAnalisados()
        {
            return _contratanteApplication.ListarPorAnalise(false);
        }

        [Route("api/contratante/listarnaoaprovados")]
        [HttpPost]
        public IList<ContratanteDTO> ListarNaoAprovados()
        {
            return _contratanteApplication.ListarPorAprovacao(false);
        }

        [Route("api/contratante/buscar")]
        [HttpPost]
        public UsuarioEditDTO Buscar(BaseRequest request)
        {
            return _contratanteApplication.BuscarContratantePorId(request.Id);
        }

    }
}   