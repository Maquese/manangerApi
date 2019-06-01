using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class PrestadorDeServico : Usuario
    {
        public IList<Competencia> Competencias { get; set; }
    }
}