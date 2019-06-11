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

        [HttpPost]
        [Route("api/dropdown/competencias")]
        public IList<KeyValuePair<int,string>> Competencias()
        {
           return _idropDownApplication.DadosCompetencia();
        }

        [HttpPost]
        [Route("api/dropdown/condicoesclinicas")]
        public IList<KeyValuePair<int,string>> CondicoesClinicas()
        {
           return _idropDownApplication.DadosCondicaoClinica();
        }

        [HttpPost]
        [Route("api/dropdown/medicamentos")]
        public IList<KeyValuePair<int,string>> Medicamentos()
        {
           return _idropDownApplication.DadosMedicamento();
        }

    }
}