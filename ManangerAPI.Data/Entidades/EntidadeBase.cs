namespace ManangerAPI.Data.Entidades
{
    public abstract class EntidadeBase
    {
        public int Id {get;set;}
        
        public int StatusEntidadeId { get; set; }
        public StatusEntidade StatusEntidade { get; set; }
    }
}