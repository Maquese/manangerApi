using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManangerAPI.Data.Entidades
{
    public class Contratante : Usuario
    {       
        public IList<Beneficiario> Beneficiarios { get; set; }
    }
}