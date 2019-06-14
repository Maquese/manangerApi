using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IMedicamentoApplication
    {
         void Cadastrar( string nome,string contraIndicacao, string bula, string indicacao, int tipo, int viaDeUso, string efeitoColateral);

         void Editar(int idMedicamento,string nome,string contraIndicacao, string bula, string indicacao, int tipo, int viaDeUso, string efeitoColateral);

         void Remover(int idMedicamento);

         IList<MedicamentoListaDTO> Listar();

         MedicamentoDTO Detalhar(int idMedicamento);
         
    }
}