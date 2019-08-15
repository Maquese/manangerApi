using System;

namespace ManangerAPI.RequestsData
{
    public class SolicitacaoContratoRequest
    {
        public int IdContratante { get; set; }
        public int IdPrestadorDeServico { get; set; }
        public int IdBeneficiario { get; set; }
        public DateTime DataFim { get; set; }
        public string Comentario { get; set; }
        public bool TempoIndeterminado { get; set; }
    }
}