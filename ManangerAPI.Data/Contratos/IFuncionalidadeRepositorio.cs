using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IFuncionalidadeRepositorio : IRepositorio<Funcionalidade>
    {
         IList<Funcionalidade> ListarPorPerfil(int idPerfil);
    }
}