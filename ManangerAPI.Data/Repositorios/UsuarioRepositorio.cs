using System.Linq;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ManangerAPI.Data.Repositorios
{
    public class UsuarioRepositorio : Repositorio<Usuario> , IUsuarioRepositorio
    {
        public UsuarioRepositorio()
        {
            
        }

        public Usuario Logar(string login, string senha)
        {
            return _contexto.Usuario.Where(x => x.Login == login && x.Senha == senha && x.StatusEntidadeId == 0).FirstOrDefault();
        }
    }
}