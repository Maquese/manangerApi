using System;
using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class Beneficiario : EntidadeBase
    {
        public Contratante Usuario { get; set; }
        public int ContratanteId { get; set; } 
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Sexo { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string CondicoesClinicas { get; set; }
        public bool TermoDeResponsalidade { get; set; }
        public string Numero { get; set; }

        public virtual IList<Medicamento> Medicamentos {get;set;}
    }
}