using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ManangerAPI.Data.Repositorios
{
    public class UsuarioRepositorio : Repositorio<Usuario> , IUsuarioRepositorio
    {
        public UsuarioRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public Usuario Logar(string login, string senha)
        {
            return _contexto.Usuario.Where(x => x.Login == login && x.Senha == senha && x.Status == 1 && x.Analisado && x.Aprovado).FirstOrDefault();
        }

        public bool VerificaCpfJaCadastrado(string cfp)
        {
            return _contexto.Usuario.Where(x => x.Cpf == cfp).FirstOrDefault() != null;
        }

        public bool VerificaEmailJaCadastrado(string email)
        {
            return _contexto.Usuario.Where(x => x.Email == email).FirstOrDefault() != null;
        }
    }
}