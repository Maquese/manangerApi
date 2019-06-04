using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{ 
    public interface IBeneficiarioCondicaoClinicaRepositorio : IRepositorio<BeneficiarioCondicaoClinica>
    {
         IList<BeneficiarioCondicaoClinica> EncontrarPorBeneficiarioId(int id);
    }
}