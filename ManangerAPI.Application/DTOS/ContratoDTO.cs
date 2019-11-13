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
        public DateTime? DataFim { get; set; }
        public string NomeContratante { get; set; }
        public string NomeBeneficiario { get; set; }
        public string NomePrestadorDeServico { get; set; }
        public DateTime DataSolicitacao { get; set; }         
        public string Comentario { get; set; }
        public string SexoNome { get; set; }
        public DateTime BeneficiarioDataNascimento { get; set; }
        public string BeneficiarioBairro { get; set; }
        public string TelefonePrestador { get; set; }
        public string TelefoneContratante { get; set; }
        public string ComentarioEncerramentoPrestador { get;  set; }
        public string ComentarioEncerramentoContratante { get; set; }
        public double RatingContratante { get; set; }
        public double RatingPrestador { get; set; }
    }
}