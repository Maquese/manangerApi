namespace ManangerAPI.Application.DTOS
{
    public class EnderecoCepDTO
    {
        public 	string Uf { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; } 
        public int IdCidade { get; set; }
        public string Rua { get; set; }

    }
}