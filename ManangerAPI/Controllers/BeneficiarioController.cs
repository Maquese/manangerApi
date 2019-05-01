using ManangerAPI.Application.Contratos;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly IBeneficiarioApplication _beneficiarioApplication;

        public BeneficiarioController(IBeneficiarioApplication beneficiarioApplication)
        {
            _beneficiarioApplication = beneficiarioApplication;
        }

        [HttpPost]
        [Route("api/beneficiario/adicionar")]
        public void Adicionar(BeneficiarioRequest request)
        {
            _beneficiarioApplication.Adicionar(request.IdContratante,request.Nome);
        }
    }
}