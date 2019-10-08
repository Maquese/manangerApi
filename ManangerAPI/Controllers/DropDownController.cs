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

        [HttpPost]
        [Route("api/dropdown/viadeusomedicamento")]
        public IList<KeyValuePair<int,string>> ViaDeUsoMedicamento()
        {
           return _idropDownApplication.DadosViaDeUsoMedicamento();
        }

        [HttpPost]
        [Route("api/dropdown/tipomedicamento")]
        public IList<KeyValuePair<int,string>> TipoMedicamento()
        {
           return _idropDownApplication.DadosTipoMedicamento();
        }
        
        [HttpPost]
        [Route("api/dropdown/posologia")]
        public IList<KeyValuePair<int,string>> Posologia()
        {
           return _idropDownApplication.DadosPosologia();
        }

        [HttpPost]
        [Route("api/dropdown/prestadorcontrato")]
        public IList<KeyValuePair<int,string>> PrestadorContrato(BaseRequest request)
        {
           return _idropDownApplication.DadosPrestadorContrato(request.Id);
        }

        [HttpPost]
        [Route("api/dropdown/medicamentosbeneficiario")]
        public IList<KeyValuePair<int,string>> MedicamnetosBeneficiario(BaseRequest request)
        {
           return _idropDownApplication.DadosBeneficiarioMedicamento(request.Id);
        }
        
    }
}