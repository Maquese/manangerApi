using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Application.Enums;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IUsuarioApplication
    {
        
        public void Analisar(int idUsuario, bool aprovado)
        {
            var usuario =_usuarioRepositorio.Encontrar(idUsuario);
            usuario.Aprovado = aprovado;
            usuario.Analisado = true;
            _usuarioRepositorio.Save();
        }

        public void Deletar(int id)
        {
            _usuarioRepositorio.LogicDelete(_usuarioRepositorio.Encontrar(id));
            _usuarioRepositorio.Save();
        }

        public IList<UsuarioDTO> ListarTodos()
        {
            return _usuarioRepositorio.Listar().Select(x => new UsuarioDTO{Id = x.Id, Nome = x.Nome}).ToList();
        }

        public UsuarioDTO Logar(string login, string senha)
        {
            var usuario = _usuarioRepositorio.Logar(login,senha);            
            UsuarioDTO retorno = null;
            if(usuario != null)
            {
                 retorno = new UsuarioDTO{Id = usuario.Id,Nome = usuario.Nome};
            foreach (var item in _acessoRepositorio.AcessoDoUsuario(usuario.Id))
            {
                var acesso = new AcessoDTO{Perfil = (PerfilEnum)item.PerfilId};
                acesso.FuncionalidadeDTO = item.Funcionalidade.Select(x => new FuncionalidadeDTO{Id = x.Id, Path = x.Path }).ToList();
            }
            }
            return retorno;
        }
    }
}