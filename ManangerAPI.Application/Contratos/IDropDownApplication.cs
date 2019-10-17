using System.Collections.Generic;

namespace ManangerAPI.Application.Contratos
{
    public interface IDropDownApplication
    {
         IList<KeyValuePair<string,string>> DadosEstado();
         IList<KeyValuePair<int,string>> DadosCidade(string uf);
         IList<KeyValuePair<int,string>> DadosCompetencia();
         IList<KeyValuePair<int,string>> DadosCondicaoClinica();
         IList<KeyValuePair<int,string>> DadosMedicamento();
         IList<KeyValuePair<int,string>> DadosViaDeUsoMedicamento();
         IList<KeyValuePair<int,string>> DadosTipoMedicamento();
         IList<KeyValuePair<int,string>> DadosPosologia();
         IList<KeyValuePair<int,string>> DadosPrestadorContrato(int idBeneficiario);
         IList<KeyValuePair<int,string>> DadosBeneficiarioMedicamento(int beneficiarioId);
         IList<KeyValuePair<int,string>> DadosUnidadeMedida();
         IList<KeyValuePair<int,string>> DadosEspecialidadesMedicas();

         
    }
}