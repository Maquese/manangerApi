using System.Collections.Generic;

namespace ManangerAPI.Data.Entidades
{
    public class Usuario : EntidadeBase
    {
        public IList<Acesso> Acessos {get;set;}
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}