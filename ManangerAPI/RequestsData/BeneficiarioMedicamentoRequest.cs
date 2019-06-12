namespace ManangerAPI.RequestsData
{
    public class BeneficiarioMedicamentoRequest
    {
        public int BeneficiarioId { get; set; }
        public int MedicamentoId { get; set; }
        public int PosologiaId { get; set; }
        public int Quantidade { get; set; }
    }
}