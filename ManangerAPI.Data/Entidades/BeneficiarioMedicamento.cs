namespace ManangerAPI.Data.Entidades
{
    public class BeneficiarioMedicamento : EntidadeBase
    {
        public int BeneficiarioId { get; set; }
        public int MedicamentoId { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}