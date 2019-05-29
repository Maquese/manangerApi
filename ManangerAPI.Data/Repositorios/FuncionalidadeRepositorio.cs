using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class FuncionalidadeRepositorio : Repositorio<Funcionalidade>, IFuncionalidadeRepositorio
    {
        public FuncionalidadeRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<Funcionalidade> ListarPorPerfil(int idPerfil)
        {
            return _contexto.Funcionalidade.Where(x => x.PerfilId == idPerfil).ToList();
        }
    }
}