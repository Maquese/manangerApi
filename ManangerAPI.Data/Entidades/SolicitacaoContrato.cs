using System;

namespace ManangerAPI.Data.Entidades
{
    public class SolicitacaoContrato : EntidadeBase
    {
        public int ContratanteId { get; set; }
        public virtual Contratante Contratante { get; set; }
        public int PrestadorDeServicoId { get; set; }
        public virtual PrestadorDeServico PrestadorDeServico { get; set; }
        public int BeneficiarioId { get; set; }
        public virtual  Beneficiario Beneficiario { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Comentario { get; set; }
        public DateTime? DataFim { get; set; }
        public bool TempoIndeterminado { get; set; }
    }
}