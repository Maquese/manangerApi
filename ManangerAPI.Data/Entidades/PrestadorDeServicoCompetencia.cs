namespace ManangerAPI.Data.Entidades
{
    public class PrestadorDeServicoCompetencia : EntidadeBase
    {
        public int PrestadorDeServicoId { get; set; }
        public int CompetenciaId { get; set; }
        public virtual PrestadorDeServico PrestadorDeServico { get; set; }
        public virtual Competencia Competencia { get; set; }    
    }
}