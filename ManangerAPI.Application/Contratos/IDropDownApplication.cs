using System.Collections.Generic;

namespace ManangerAPI.Application.Contratos
{
    public interface IDropDownApplication
    {
         IList<KeyValuePair<string,string>> DadosEstado();
         IList<KeyValuePair<int,string>> DadosCidade();
         IList<KeyValuePair<int,string>> DadosCompetencia();
         IList<KeyValuePair<int,string>> DadosCondicaoClinica();
    }
}