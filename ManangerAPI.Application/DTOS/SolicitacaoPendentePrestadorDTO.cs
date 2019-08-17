using System;
namespace ManangerAPI.Application.DTOS
{
    public class SolicitacaoPendentePrestadorDTO
    {
        public int Id { get; set; }
        public string NomeBeneficiario { get; set; }
        public string NomeContratante { get; set; }
        public DateTime DataSolicitacao { get; set; }
    }
}