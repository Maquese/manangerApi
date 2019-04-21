using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IAcessoRepositorio : IRepositorio<Acesso>
    {
         IList<Acesso> AcessoDoUsuario(int idUsuario);
    }
}