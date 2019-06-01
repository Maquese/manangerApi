namespace ManangerAPI.Data.Entidades
{
    public class BeneficiarioCondicaoClinica : EntidadeBase
    {
        public int BeneficiarioId { get; set; }
        public int CondicaoClinicaId { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
        public virtual CondicaoClinica CondicaoClinica { get; set; }
    }
}