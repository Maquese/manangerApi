using System;

namespace ManangerAPI.Application.DTOS
{
    public class ContratoDTO
    {
        public int SolicitacaoContratoId { get; set; }
        public int Id { get; set; }
        public int ContratanteId { get; set; }
        public int BeneficiarioId { get; set; }
        public int PrestadorDeServicoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string NomeContratante { get; set; }
        public string NomeBeneficiario { get; set; }
        public string NomePrestadorDeServico { get; set; }
        public DateTime DataSolicitacao { get; set; }         
        public string Comentario { get; set; }
    }
}