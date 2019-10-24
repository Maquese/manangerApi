using System;

namespace ManangerAPI.Application.DTOS
{
    public class ListagemPrestadorGestorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Imagem { get; set; }
        public string Telefone { get; set; }
    }
}