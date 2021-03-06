using System;

namespace ManangerAPI.RequestsData
{
    public class TarefaRequest : BaseRequest
    {
        public string Titulo { get; set; }
        public int  BeneficiarioId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public bool TodosOsDias { get; set; }
        public string CorHexa { get; set; }
        public string Comentario { get; set; }
        public DateTime Data { get; set; }        
        public int? BeneficiarioMedicamentoId { get; set; }
        public int? QuantidadeMedicamento { get; set; }
    }
}