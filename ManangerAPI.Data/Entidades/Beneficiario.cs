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
        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual Estado Estado { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public virtual IList<BeneficiarioCondicaoClinica> BeneficiarioCondicaoClinica { get; set; }
        public bool TermoDeResponsalidade { get; set; }
        public string Numero { get; set; }

        public virtual IList<BeneficiarioMedicamento> Medicamentos {get;set;}
    }
}