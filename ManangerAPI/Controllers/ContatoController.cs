using ManangerAPI.Application.Contratos;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoApplication _contatoApplication;

        public ContatoController(IContatoApplication contatoApplication)
        {
            _contatoApplication = contatoApplication;
        }

        [HttpPost]
        [Route("api/Contato/CriarNovo")]
        public int CriarNovo(ContatoRequest request)
        {
            return _contatoApplication.CriarNovo(request.Nome,request.Email,request.TipoContato,request.Observacao);
        }
    }
}