using System;

namespace ManangerAPI.Data.Entidades
{
    public class Tarefa : EntidadeBase
    {
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int ContratoId { get; set; }
        public virtual Contrato Contrato { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string CorHexa { get; set; }
        public string Comentario { get; set; }
        public bool TodosOsDias { get; set; }
    }
}