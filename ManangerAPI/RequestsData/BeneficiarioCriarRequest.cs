using System;
using System.Collections.Generic;

namespace ManangerAPI.RequestsData
{
    public class BeneficiarioCriarRequest 
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Sexo { get; set; }
        public string Telefone { get; set; }
        public int Cidade { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public IList<int> CondicoesClinicas { get; set; }
        public bool TermoDeResponsalidade { get; set; }
        public int IdContratante { get;  set; }
        public string Numero { get;  set; }
    }
}