using System;

namespace ManangerAPI.RequestsData
{
    public class GestorRequest
    {
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
        public int Status { get; set; }   
        public string Historico { get; set; }
        public string Cursos { get; set; }

        public string Estado { get; set; }        
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
    }
}