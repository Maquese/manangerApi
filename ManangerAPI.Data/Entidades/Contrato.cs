using System;

namespace ManangerAPI.Data.Entidades
{
    public class Contrato : EntidadeBase
    {
        public Contratante Contratante { get; set; }
        public Beneficiario Beneficiario { get; set; }
        public PrestadorDeServico PrestadorDeServico { get; set; }
        public int ContratanteId { get; set; }
        public int BeneficiarioId { get; set; }
        public int PrestadorDeServicoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}