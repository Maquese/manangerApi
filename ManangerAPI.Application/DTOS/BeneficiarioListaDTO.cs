using System;

namespace ManangerAPI.Application.DTOS
{
    public class BeneficiarioListaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
         public string CondicoesClinicas { get; set; }
         public int Sexo { get; set; }
         public DateTime DataNascimento { get; set; }
        public string Cidade { get;  set; }
        public string Bairro { get;  set; }
        public int CidadeId { get;  set; }
    }
}