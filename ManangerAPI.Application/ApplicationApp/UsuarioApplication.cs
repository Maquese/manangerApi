using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;

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
                retorno.Acessos.Add(new AcessoDTO{Nome = item.Funcionalidade.Nome, Path = item.Funcionalidade.Path});
            }
            }
            return retorno;
        }
    }
}