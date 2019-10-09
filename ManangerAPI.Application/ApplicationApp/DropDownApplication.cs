using System.Collections.Generic;
using ManangerAPI.Application.Contratos;
using System.Linq;
using ManangerAPI.Application.Enums;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IDropDownApplication
    {
        public IList<KeyValuePair<int, string>> DadosBeneficiarioMedicamento(int beneficiarioId)
        {
            return _beneficiarioMedicamentoRepositorio.GerarDropDown(beneficiarioId);
        }

        public IList<KeyValuePair<int, string>> DadosCidade(string uf)
        {
            return _cidadeRepositorio.GerarDropDown(uf);
        }

        public IList<KeyValuePair<int, string>> DadosCompetencia()
        {
            return _competenciaRepositorio.GerarDropDown();
        }

        public IList<KeyValuePair<int, string>> DadosCondicaoClinica()
        {
            return _condicaoClinicaRepositorio.GerarDropDown();
        }

        public IList<KeyValuePair<string, string>> DadosEstado()
        {
            return _estadoRepostorio.GerarDropDown();
        }

        public IList<KeyValuePair<int, string>> DadosMedicamento()
        {
            return _medicamentoRepositorio.GerarDropDown();
        }

        public IList<KeyValuePair<int, string>> DadosPosologia()
        {
            return _posologiaRepositorio.GerarDropDown();
        }

        public IList<KeyValuePair<int, string>> DadosPrestadorContrato(int idBeneficiario)
        {
            return _contratoRepositorio.GerarDropDown(idBeneficiario);
        }

        public IList<KeyValuePair<int, string>> DadosTipoMedicamento()
        {
            return _tipoMedicamentoRepositorio.GerarDropDown();
        }

        public IList<KeyValuePair<int, string>> DadosUnidadeMedida()
        {
            var lista = new List<KeyValuePair<int,string>>();
            lista.Add(new KeyValuePair<int, string>((int)UnidadeMedidaEnum.Litro,UnidadeMedidaEnum.Litro.ToString()));
            
            lista.Add(new KeyValuePair<int, string>((int)UnidadeMedidaEnum.ML,UnidadeMedidaEnum.ML.ToString()));
            
            lista.Add(new KeyValuePair<int, string>((int)UnidadeMedidaEnum.Grama,UnidadeMedidaEnum.Grama.ToString()));
            
            lista.Add(new KeyValuePair<int, string>((int)UnidadeMedidaEnum.Unidade,UnidadeMedidaEnum.Unidade.ToString()));

            lista.Add(new KeyValuePair<int, string>((int)UnidadeMedidaEnum.Comprimido,UnidadeMedidaEnum.Comprimido.ToString()));
            return lista;
        }

        public IList<KeyValuePair<int, string>> DadosViaDeUsoMedicamento()
        {
            return _viaDeUsoMedicamentoRepositorio.GerarDropDown();
        }
    }
}