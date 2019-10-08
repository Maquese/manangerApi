using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ManangerAPI.Data.Repositorios
{
    public class BeneficiarioMedicamentoRepositorio : Repositorio<BeneficiarioMedicamento>, IBeneficiarioMedicamentoRepositorio
    {
        public BeneficiarioMedicamentoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public BeneficiarioMedicamento EncontrarCompleto(int beneficiarioMedicamentoId)
        {
            return _contexto.BeneficiarioMedicamento.Include("Medicamento").Where(x => x.Id == beneficiarioMedicamentoId).FirstOrDefault();
        }

        public IList<KeyValuePair<int, string>> GerarDropDown(int beneficiarioId)
        {
            var retorno = new List<KeyValuePair<int,string>>();
            retorno.Add(new KeyValuePair<int, string>(0,"Selecione"));
            retorno.AddRange(_contexto.BeneficiarioMedicamento.Include("Medicamento")
                   .Where(x => x.BeneficiarioId == beneficiarioId)
                   .Select(x => new KeyValuePair<int, string>(x.Id, x.Medicamento.Nome)).ToList());
            return retorno;
        }

        public IList<BeneficiarioMedicamento> ListarPorBeneficiarioId(int idBeneficiario)
        {
            return _contexto.BeneficiarioMedicamento.Where(x => x.BeneficiarioId == idBeneficiario && x.Status == 1).ToList();
        }
    }
}