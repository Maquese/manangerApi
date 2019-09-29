using System;

namespace ManangerAPI.Data.Entidades
{
    public class BeneficiarioMedicamento : EntidadeBase
    {
        public int BeneficiarioId { get; set; }
        public int MedicamentoId { get; set; }
        public int PosologiaId { get; set; }
        public int Quantidade { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        public virtual Posologia Posologia { get; set; }
        public DateTime DataDeInicio { get; set; }
        public DateTime? DataFim { get; set; }  
        public double EmbalagemQTD { get; set; }
        public int UnidadeMedida { get; set; }  
    }
}