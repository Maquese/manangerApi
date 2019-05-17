namespace ManangerAPI.Data.Entidades
{
    public class Medicamento : EntidadeBase
    {
        public string Nome { get; set; }
        public string ContraIndicacao { get; set; }
        public string Bula { get; set; }
        public string Indicao { get; set; }
        public int Tipo { get; set; }///comprimido, gota, efervece
        public int ViaDeUso { get; set; }///oral, etc
        public string EfeitoColateral  { get; set; }
    }
}