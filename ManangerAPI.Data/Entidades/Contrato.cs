using System;
using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class Contrato : EntidadeBase
    {
        public virtual Contratante Contratante { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
        public virtual PrestadorDeServico PrestadorDeServico { get; set; }
        public virtual SolicitacaoContrato SolicitacaoContrato { get; set; }
        public int SolicitacaoContratoId { get; set; }
        public int ContratanteId { get; set; }
        public int BeneficiarioId { get; set; }
        public int PrestadorDeServicoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public virtual IList<Tarefa> Tarefa { get; set; }
        public string ComentarioEncerramento { get; set; }
        public bool? EncerradoPorContratante { get; set; } 
    }
}