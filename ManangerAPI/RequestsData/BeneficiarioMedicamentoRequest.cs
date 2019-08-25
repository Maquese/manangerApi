using System;

namespace ManangerAPI.RequestsData
{
    public class BeneficiarioMedicamentoRequest : BaseRequest
    {
        public int BeneficiarioId { get; set; }
        public int MedicamentoId { get; set; }
        public int PosologiaId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}