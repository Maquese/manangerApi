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
            var usuario = _usuarioRepositorio.Encontrar(idUsuario);
            usuario.Aprovado = aprovado;
            usuario.Analisado = true;
            _usuarioRepositorio.Save();
        }

        public DadosCadastraisDTO BuscarDadosCadastrais(int idUsuario)
        {
            var retorno = new DadosCadastraisDTO();
            var usuario = _usuarioRepositorio.Encontrar(idUsuario);
            var endereco =  _enderecoRepositorio.EncontrarPorUsuario(idUsuario);
            retorno.Nome = usuario.Nome;
            retorno.DataNascimento = usuario.DataNascimento;
            retorno.Sexo = ((SexoEnum)usuario.Sexo).ToString();
            retorno.Telefone = usuario.Telefone;
            retorno.Email = usuario.Email;
            retorno.Cep  = endereco.Cep;
            retorno.Cpf = usuario.Cpf;
            retorno.Bairro = endereco.Bairro;
            retorno.Rua = endereco.Rua;
            retorno.Numero = endereco.Numero;
            retorno.Complemento = endereco.Complemento;
            retorno.Cidade = _cidadeRepositorio.Encontrar(endereco.CidadeId).Nome;
            retorno.Comentario = usuario.Comentario;
            retorno.Imagem = usuario.Imagem;
            retorno.Curriculo = usuario.Curriculo;
            retorno.Estado = _estadoRepostorio.Encontrar(endereco.EstadoId).Nome;
            retorno.Competencias = _prestadorDeServicoCompetenciaRepositorio.EncontrarPorPrestadorDeServicoId(idUsuario).Select(x => x.CompetenciaId).ToList();
            
            return retorno;
        }

        public UsuarioDTO BuscarDadosEmail(int idUsuario)
        {
            var usuario = _usuarioRepositorio.Encontrar(idUsuario);
            return new UsuarioDTO { Nome = usuario.Nome, Email = usuario.Email };
        }

        public void Deletar(int id)
        {
            _usuarioRepositorio.LogicDelete(_usuarioRepositorio.Encontrar(id));
            _usuarioRepositorio.Save();
        }

        public IList<UsuarioDTO> ListarTodos()
        {
            return _usuarioRepositorio.Listar().Select(x => new UsuarioDTO { Id = x.Id, Nome = x.Nome }).ToList();
        }

        public IList<UsuarioDTO> ListarUsuariosPorPerfil(PerfilEnum perfilId)
        {
            return _usuarioRepositorio.ListarTodosOsUsuariosPorPerfil((int)perfilId).Select(x => new UsuarioDTO
            {
                Id = x.Id,
                Nome = x.Nome,
                QuantidadeBeneficiario = _beneficiarioRepositorio.ListarPorContratante(x.Id).Count,
                QuantidadeContratos = PerfilEnum.Contratante == perfilId ? _contratoRepositorio.ListarContratoContratante(x.Id).Count : _contratoRepositorio.ListarContratoPrestador(x.Id).Count
            }).ToList();
        }

        public UsuarioDTO Logar(string login, string senha)
        {
            var usuario = _usuarioRepositorio.Logar(login, senha);
            UsuarioDTO retorno = null;
            if (usuario != null)
            {
                retorno = new UsuarioDTO { Id = usuario.Id, Nome = usuario.Nome, DataNascimento = usuario.DataNascimento, 
                                           Email = usuario.Email, Imagem = usuario.Imagem };
                retorno.Acessos = new List<AcessoDTO>();
                foreach (var item in _acessoRepositorio.AcessoDoUsuario(usuario.Id))
                {
                    var acesso = new AcessoDTO { Perfil = (PerfilEnum)item.PerfilId };
                    acesso.FuncionalidadeDTO = _funcionalidadeRepositorio.ListarPorPerfil(item.PerfilId).Select(x => new FuncionalidadeDTO { Id = x.Id, Path = x.Path }).ToList();
                    retorno.Acessos.Add(acesso);
                }
            }
            return retorno;
        }

        public UsuarioDTO LogarPrestador(string login, string senha)
        {
            var usuario = _usuarioRepositorio.Logar(login, senha);
            UsuarioDTO retorno = null;
            if (usuario != null)
            {
                var dado = _acessoRepositorio.AcessoDoUsuario(usuario.Id).Where(x => x.PerfilId == (int) PerfilEnum.PrestadorDeServico).FirstOrDefault();
                if(dado != null)
                {            
                    retorno = new UsuarioDTO { Id = usuario.Id, Nome = usuario.Nome, DataNascimento = usuario.DataNascimento, 
                                               Email = usuario.Email, Imagem = usuario.Imagem };
                }                
            }
            return retorno;
        }

        public bool VerificaCpfJaCadastrado(string cpf)
        {
            return _usuarioRepositorio.VerificaCpfJaCadastrado(cpf);
        }

        public bool VerificaEmailJaCadastrado(string email)
        {
            return _usuarioRepositorio.VerificaEmailJaCadastrado(email);
        }

        public bool VerificaLoginJaCadastrado(string login)
        {
            return _usuarioRepositorio.VerificaMesmoLogin(login);
        }
    }
}