using ManangerAPI.Application.Contratos;
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
                                              contratante.Rua);
        }

    }
}   