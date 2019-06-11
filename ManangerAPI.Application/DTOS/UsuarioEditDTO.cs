using System;
using System.Collections.Generic;

namespace ManangerAPI.Application.DTOS
{
    public class UsuarioEditDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; } 
        public int Sexo { get; set; }
        public string Cpf { get; set; }

        public string Telefone { get; set; }
        public string Comentario { get; set; }
        public bool Termos { get; set; }
        public string Estado { get; set; }
        public int Cidade { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Imagem { get; set; }
        public string Curriculo { get; set; }
        public IList<int> Competencias { get; set; }
    }
}