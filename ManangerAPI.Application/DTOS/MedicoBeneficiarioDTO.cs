namespace ManangerAPI.Application.DTOS
{
    public class MedicoBeneficiarioDTO 
    {
        public int Id { get; set; }
         public int BeneficiarioId { get; set; }
        public string Nome { get; set; }
        public int TelefoneConsultorio { get; set; }
        public int Celular { get; set; }
        public int EspecialidadeMedicoId { get; set; }
        public bool Convenio { get; set; }

        ///// Endereço do médico no caso da clinica
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string EstadoUf { get; set; }
    }
}