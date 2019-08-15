using System;

namespace ManangerAPI.Application.DTOS
{
    public class SolicitacaoPendenteDTO
    {
        public int Id { get; set; }
        public string NomePrestador { get; set; }
        public DateTime DataSolicitacao { get; set; }
    }
}