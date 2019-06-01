using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class CondicaoClinica : EntidadeBase
    {
        public CondicaoClinica()
        {
        }
        public string Nome { get; set; }
        public virtual IList<BeneficiarioCondicaoClinica> BeneficiarioCondicaoClinica { get; set; }
    }
}