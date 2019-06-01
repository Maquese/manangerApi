using System;
using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public abstract class Usuario : EntidadeBase
    {
        public virtual IList<Acesso> Acessos {get;set;}
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Sexo { get; set; }
        public string Cpf { get; set; }
        public string Telefone {get;set;}
        public string Comentario { get; set; }
        public bool Termos { get; set; }
        public Endereco Endereco { get; set; }
        public bool Aprovado { get; set; }
        public bool Analisado { get; set; }    
        public string Imagem { get; set; }
    }
}