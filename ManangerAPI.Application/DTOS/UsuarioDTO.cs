using System;
using System.Collections.Generic;

namespace ManangerAPI.Application.DTOS
{
    public class UsuarioDTO
    {
        public UsuarioDTO()
        {
            Acessos = new List<AcessoDTO>();
            Contratos = new List<ListaContratoEncerradoDTO>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<AcessoDTO> Acessos {get;set;}
        public string Imagem { get; set; }        
        public int QuantidadeBeneficiario { get; set; }
        public int QuantidadeContratos { get; set; }
        public List<ListaContratoEncerradoDTO> Contratos {get;set;}
        public double RatingUsuario { get; set; }
    }
}