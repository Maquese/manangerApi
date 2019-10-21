using System;

namespace ManangerAPI.RequestsData
{
    public class TarefaRealizadaRequest
    {
        public int TarefaId { get; set; }
        public string Comentario { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public bool Realizada { get; set; }
        public int? TarefaRealizadaId { get; set; }
    }
}