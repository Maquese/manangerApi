using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class BeneficiarioRepositorio : Repositorio<Beneficiario>, IBeneficiarioRepositorio
    {
        public BeneficiarioRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<Beneficiario> ListarPorContratante(int idContratante)
        {
            return _contexto.Beneficiario.Where(x => x.ContratanteId == idContratante).ToList();
        }
    }
}