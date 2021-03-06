namespace ManangerAPI.Data.Entidades
{
    public class MedicoBeneficiario : EntidadeBase
    {
        public int BeneficiarioId { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
        public string Nome { get; set; }
        public int TelefoneConsultorio { get; set; }
        public int Celular { get; set; }
        public int EspecialidadeMedicoId { get; set; }
        public EspecialidadeMedica EspecialidadeMedica { get; set; }
        public bool Convenio { get; set; }

        ///// Endereço do médico no caso da clinica
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
                
    }
}