using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace ManangerAPI.Controllers
{
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
    }
}