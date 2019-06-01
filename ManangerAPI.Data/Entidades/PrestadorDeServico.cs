using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class PrestadorDeServico : Usuario
    {
        public virtual IList<PrestadorDeServicoCompetencia> PrestadorDeServicoCompetencia { get; set; }
    }
}