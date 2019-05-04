using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class Acesso : EntidadeBase
    {
         public int UsuarioId {get;set;}
         public int PerfilId { get; set; }
         public virtual Perfil Perfil { get; set; }
         public virtual Usuario Usuario {get;set;}         
    }
}