using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using ManangerAPI.RequestsData;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
    [ApiController]
    public class DropDownController : ControllerBase
    {
        private readonly IDropDownApplication _idropDownApplication;

        public DropDownController(IDropDownApplication dropDownApplication)
        {
            _idropDownApplication = dropDownApplication;
        }

        [HttpPost]
        [Route("api/dropdown/estados")]
        public IList<KeyValuePair<string,string>> Estados()
        {
           return _idropDownApplication.DadosEstado();
        }

        [HttpPost]
        [Route("api/dropdown/cidadeporestado")]
        public IList<KeyValuePair<int,string>> CidadePorEstado(DropDownRequest equest)
        {
           return _idropDownApplication.DadosCidade(equest.Uf);
        }

    }
}