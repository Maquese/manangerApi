using System;
using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class Perfil : EntidadeBase
    {
        public String Nome { get; set; }        
         public virtual IList<Funcionalidade> Funcionalidades {get;set;}
    }
}