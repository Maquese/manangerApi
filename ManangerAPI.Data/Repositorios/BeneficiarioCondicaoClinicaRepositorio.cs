using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class BeneficiarioCondicaoClinicaRepositorio : Repositorio<BeneficiarioCondicaoClinica>, IBeneficiarioCondicaoClinicaRepositorio
    {
        public BeneficiarioCondicaoClinicaRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<BeneficiarioCondicaoClinica> EncontrarPorBeneficiarioId(int id)
        {
           return _contexto.BeneficiarioCondicaoClinica.Where(x => x.BeneficiarioId == id && x.Status == 1).ToList();
        }
    }
}