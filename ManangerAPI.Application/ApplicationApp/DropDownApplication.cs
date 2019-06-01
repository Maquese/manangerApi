using System.Collections.Generic;
using ManangerAPI.Application.Contratos;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IDropDownApplication
    {
        public IList<KeyValuePair<int, string>> DadosCidade(string uf)
        {
            return _cidadeRepositorio.GerarDropDown(uf);
        }

        public IList<KeyValuePair<int, string>> DadosCompetencia()
        {
            throw new System.NotImplementedException();
        }

        public IList<KeyValuePair<int, string>> DadosCondicaoClinica()
        {
            throw new System.NotImplementedException();
        }

        public IList<KeyValuePair<string, string>> DadosEstado()
        {
            return _estadoRepostorio.GerarDropDown();
        }
    }
}