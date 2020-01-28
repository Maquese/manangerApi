using System;
using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class Tarefa : EntidadeBase
    {
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public int BeneficiarioId { get; set; }
        public Beneficiario Beneficiario { get; set; }
        public DateTime? DataFim { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string CorHexa { get; set; }
        public string Comentario { get; set; }
        public bool TodosOsDias { get; set; }
        public int? BeneficiarioMedicamentoId { get; set; }
        public int? QuantidadeMedicamento { get; set; }
        public virtual IList<TarefaRealizada> TarefasRealizada { get; set; }
    }
}