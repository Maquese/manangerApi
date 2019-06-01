using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class Competencia : EntidadeBase
    {
        public string Nome { get; set; }   
        public virtual IList<PrestadorDeServicoCompetencia> PrestadorDeServicoCompetencia { get; set; }
    }
}