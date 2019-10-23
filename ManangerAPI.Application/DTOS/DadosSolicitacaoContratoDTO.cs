using System;

namespace ManangerAPI.Application.DTOS
{
    public class DadosSolicitacaoContratoDTO
    {
        public string NomeContratante { get; set; }
        public string NomeBeneficiario { get; set; }
        public string NomePrestadorDeServico { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime? DataFim { get; set; }
        public string Comentario { get; set; }
        public string TelefonePrestador { get; set; }
        public string TelefoneContratante { get;  set; }
    }
}