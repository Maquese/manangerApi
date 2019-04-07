namespace ManangerAPI.Data.Entidades
{
    public class Acesso : EntidadeBase
    {
         public int UsuarioId {get;set;}
         public int FuncionalidadeId {get;set;}  

         public Usuario Usuario {get;set;}
         public Funcionalidade FUncionalidade {get;set;}
    }
}