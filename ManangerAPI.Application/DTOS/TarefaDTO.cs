using System;

namespace ManangerAPI.Application.DTOS
{
    public class TarefaDTO
    {
        public int Id { get; set; }
        public int ContratoId { get; set; }
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string CorHexa { get; set; }
        public string Comentario { get; set; }
        public bool TodosOsDias { get; set; }
    }
}