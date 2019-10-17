using System;

namespace ManangerAPI.Data.Entidades
{
    public class TarefaRealizada : EntidadeBase
    {
        public virtual Tarefa Tarefa { get; set; }
        public int TarefaId { get; set; }
        public string Comentario { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public bool? Realizada { get; set; }
    }
}