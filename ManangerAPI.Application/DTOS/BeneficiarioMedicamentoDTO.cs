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
        public string Nome { get; set; }
        public string ContraIndicacao { get; set; }
        public string Bula { get; set; }
        public string Indicao { get; set; }
        public String TipoMedicamento { get; set; }///comprimido, gota, efervece
        public int TipoMedicamentoId { get; set; }
        public String ViaDeUsoMedicamento { get; set; }///oral, etc
        public int ViaDeUsoMedicamentoId { get; set; }
        public string EfeitoColateral  { get; set; }
        public int UnidadeMedida { get;  set; }
    }
}