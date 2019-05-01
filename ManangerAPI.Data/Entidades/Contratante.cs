using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class Contratante : Usuario
    {       
        public IList<Beneficiario> Beneficiarios { get; set; }
    }
}