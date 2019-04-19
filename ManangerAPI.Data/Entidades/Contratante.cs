namespace ManangerAPI.Data.Entidades
{
    public class Contratante  : Usuario
    {
        public int Paciente { get; set; }
        public string Medico { get; set; }
    }
}