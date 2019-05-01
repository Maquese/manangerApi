using System.Collections.Generic;
using ManangerAPI.Application.Enums;

namespace ManangerAPI.Application.DTOS
{
    public class AcessoDTO
    {
        public string Nome { get; set; }
        public List<FuncionalidadeDTO> FuncionalidadeDTO { get; set; }
        public PerfilEnum Perfil { get; set; }
    }
}