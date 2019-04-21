using System;
using System.Collections.Generic;

namespace ManangerAPI.Application.DTOS
{
    public class UsuarioDTO
    {
        public UsuarioDTO()
        {
            Acessos = new List<AcessoDTO>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<AcessoDTO> Acessos {get;set;}

    }
}