using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IContratoRepositorio : IRepositorio<Contrato>
    {
         IList<Contrato> ListarContratoPrestador(int prestadorId);
         IList<Contrato> ListarContratoBeneficiario(int beneficiarioId);
         IList<KeyValuePair<int,string>> GerarDropDown(int beneficiarioId);
         IList<Contrato> ListarContratoContratante(int contratanteId);

         IList<Contrato> ListarContratoEncerradosPrestador(int prestadorId);
         IList<Contrato> ListarContratoEncerradosBeneficiario(int beneficiarioId);
         IList<Contrato> ListarContratoEncerradosContratante(int contratanteId);

         IList<int> ListarContratosEncerradosUsuario(int perfil, int usuarioId);
         
         
    }
}