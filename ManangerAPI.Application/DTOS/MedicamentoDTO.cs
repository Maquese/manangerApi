namespace ManangerAPI.Application.DTOS
{
    public class MedicamentoDTO
    {
        public int IdMedicamento { get; set; }
        public string Nome { get; set; }
        public string ContraIndicacao { get; set; }
        public string Bula { get; set; }
        public string Indicacao { get; set; }
        public int Tipo { get; set; }///comprimido, gota, efervece
        public int ViaDeUso { get; set; }///oral, etc
        public string EfeitoColateral  { get; set; }
    }
}