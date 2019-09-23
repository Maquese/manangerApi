using System;

namespace ManangerAPI.Application.DTOS
{
    public class BeneficiarioMedicamentoDTO
    {
        public int Id { get; set; }
        public int MedicamentoId { get; set; }
        public int PosologiaId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataDeInicio { get;  set; }
        public DateTime? DataFim { get;  set; }
    }
}