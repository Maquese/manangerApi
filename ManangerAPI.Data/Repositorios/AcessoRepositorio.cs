using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ManangerAPI.Data.Repositorios
{
    public class AcessoRepositorio : Repositorio<Acesso>, IAcessoRepositorio
    {
        public AcessoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<Acesso> AcessoDoUsuario(int idUsuario)
        {
            return _contexto.Acesso.Where(x => x.UsuarioId == idUsuario).Include(x => x.Perfil).ToList();
        }
    }
}