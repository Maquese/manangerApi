using System.Collections.Generic;
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

        public IList<Usuario> ListarTodosOsUsuariosPorPerfil(int perfilId)
        {
            var acessos =  _contexto.Acesso.Where(x => x.PerfilId == perfilId).Select(x => x.UsuarioId).ToList();
            return _contexto.Usuario.Where(x => acessos.Contains(x.Id)).ToList();
        }

        public Usuario Logar(string login, string senha)
        {
            return _contexto.Usuario.Where(x => x.Login == login && x.Senha == senha && x.Status == 1 && x.Analisado && x.Aprovado).FirstOrDefault();
        }

        public Usuario LogarGestor(string login, string senha)
        {
            return  _contexto.Gestor.Where(x => x.Login == login && x.Senha == senha && x.Status == 1 && x.Analisado && x.Aprovado).FirstOrDefault();
        }

        public Usuario LogarPrestador(string login, string senha)
        {
            return _contexto.PrestadorDeServico.Where(x => x.Login == login && x.Senha == senha && x.Status == 1 && x.Analisado && x.Aprovado).FirstOrDefault();
        }

        public bool VerificaCpfJaCadastrado(string cfp)
        {
            return _contexto.Usuario.Where(x => x.Cpf == cfp).FirstOrDefault() != null;
        }

        public bool VerificaEmailJaCadastrado(string email)
        {
            return _contexto.Usuario.Where(x => x.Email == email).FirstOrDefault() != null;
        }

        public bool VerificaMesmoLogin(string login)
        {
             return _contexto.Usuario.Where(x => x.Login == login).FirstOrDefault() != null;
        }
    }
}