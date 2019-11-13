using System;

namespace ManangerAPI.Application.DTOS
{
    public class SolicitacaoPendenteDTO
    {
        public int Id { get; set; }
        public string NomePrestador { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public int IdSolicitacao { get; set; }
        public string TelefonePrestador   { get; set; }
        public string TelefoneContratante { get; set; }
        public double RatingContratante { get; set; }
        public double RatingPrestador { get; set; }
    }
}