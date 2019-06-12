using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class Medicamento : EntidadeBase
    {
        public string Nome { get; set; }
        public string ContraIndicacao { get; set; }
        public string Bula { get; set; }
        public string Indicao { get; set; }
        public int TipoMedicamentoId { get; set; }///comprimido, gota, efervece
        public virtual TipoMedicamento TipoMedicamento { get; set; }
        public int ViaDeUsoMedicamentoId { get; set; }///oral, etc
        public virtual ViaDeUsoMedicamento ViaDeUsoMedicamento { get; set; }
        public string EfeitoColateral  { get; set; }
        public virtual IList<BeneficiarioMedicamento> BeneficiarioMedicamento { get; set; }
    }
}