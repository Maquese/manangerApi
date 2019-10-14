using System;

namespace ManangerAPI.Application.DTOS
{
    public class TarefaDTO
    {
        public int Id { get; set; }
        public int ContratoId { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string CorHexa { get; set; }
        public string Comentario { get; set; }
        public string DataString { get; set; }
        public bool TarefaRealizada { get;  set; }
        public int? QuantidadeMedicamento { get; set; }
        public string NomeMedicamento { get; set; }
        public int? BeneficiarioMedicamentoId { get; set; }
    }
}