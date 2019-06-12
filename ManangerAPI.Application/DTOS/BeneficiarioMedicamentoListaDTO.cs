namespace ManangerAPI.Application.DTOS
{
    public class BeneficiarioMedicamentoListaDTO
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string NomeMedicamento { get; set; }
        public string Posologia { get; set; }
    }
}