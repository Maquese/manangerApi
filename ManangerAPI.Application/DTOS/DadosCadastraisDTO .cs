using System;

namespace ManangerAPI.Application.DTOS
{
    public class DadosCadastraisDTO 
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public  string  Sexo { get; set; }
        public string Cidade { get; set; }
        public string Comentario { get; set; }
        public string Imagem { get; internal set; }
        public string Curriculo { get; internal set; }
        public string Estado { get; internal set; }
    }
}