using System;
namespace ManangerAPI.Application.DTOS
{
    public class SolicitacaoPendentePrestadorDTO
    {
        public int Id { get; set; }
        public string NomeBeneficiario { get; set; }
        public string NomeContratante { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public int BeneficiarioId { get;  set; }
        public int ContratanteId { get;  set; }
        public string TelefonePrestador { get; set; }
        public string TelefoneContratante { get; set; }
    }
}