namespace ManangerAPI.Data.Entidades
{
    public class Funcionalidade : EntidadeBase
    {
        public string Nome {get;set;}
        public string Path {get;set;}    
        public int PerfilId { get; set; }
        public virtual Perfil Perfil { get; set; }
        
    }
}