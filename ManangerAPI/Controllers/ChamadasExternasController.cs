using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class ChamadasExternasController
    {
        private readonly ICepApplication _cepApplication;

        public ChamadasExternasController(ICepApplication cepApplication)
        {
            _cepApplication = cepApplication;
        }

        [Route("api/ChamadasExternas/BuscarEnderecoPorCep")]
        [HttpPost]
        public EnderecoCepDTO BuscarEnderecoPorCep(string cep)
        {
            try
            {
                return _cepApplication.BuscarEnderecoPorCepAsync(cep).Result;
            }
            catch (System.Exception)
            {

                throw new System.Exception("Cep inválido.");
            }

        }
    }
}