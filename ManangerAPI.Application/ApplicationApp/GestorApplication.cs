using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Application.Enums;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IGestorApplication
    {
        /// <summary>
        /// Cadastra os novos gestores 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <param name="email"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="sexo"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="comentarios"></param>
        /// <param name="termos"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="bairro"></param>
        /// <param name="cep"></param>
        /// <param name="rua"></param>
        /// <param name="numero"></param>
        /// <param name="complemento"></param>
        public void CadastrarGestor(string nome, string login, string senha, string email, DateTime dataNascimento, int sexo, string cpf, 
                              string telefone, string comentarios, bool termos, int cidade, string estado, string bairro, string cep, 
                              string rua, string numero, string complemento, string curriculo, string imagem)
        {
            Gestor gestor = new Gestor
            {
                Imagem  = imagem,
                Nome = nome,
                Login = login,
                Senha = senha,
                Email = email,
                DataNascimento = dataNascimento,
                Cpf = cpf,
                Telefone = telefone,
                Comentario = comentarios,
                Termos = termos,
                Curriculo = curriculo,
                Sexo = sexo,
                Status = (int)StatusEnum.Ativo,
                Endereco = new Endereco{
                    EstadoId = _estadoRepostorio.IdPorUf(estado),
                    CidadeId = cidade,
                    Bairro = bairro,
                    Rua = rua,
                    Numero = numero,
                    Cep = cep,
                    Complemento = complemento,
                    Status = (int)StatusEnum.Ativo
                },
                Acessos = new List<Acesso>{new Acesso{PerfilId = (int)PerfilEnum.Gestor, Status = (int)StatusEnum.Ativo} }
            };
            _gestorRepositorio.Insert(gestor);
            _gestorRepositorio.Save();
        }

        public UsuarioEditDTO EncontrarGestorPorId(int id)
        {
             var goestor = _gestorRepositorio.Encontrar(id);
            var endereco = _enderecoRepositorio.EncontrarPorUsuario(id);
            var retorno = new UsuarioEditDTO{
                Id  = goestor.Id,
                Nome = goestor.Nome,
                DataNascimento = goestor.DataNascimento,
                Login = goestor.Login,
                Termos = goestor.Termos,
                Sexo = goestor.Sexo,
                Imagem = goestor.Imagem,
                Comentario = goestor.Comentario,
                Senha = goestor.Senha,
                Telefone = goestor.Telefone,
                Estado = _estadoRepostorio.Encontrar(endereco.EstadoId).Uf,
                Cidade = endereco.CidadeId,
                Bairro = endereco.Bairro,
                Cep = endereco.Cep,
                Complemento = endereco.Complemento,
                Cpf = goestor.Cpf,
                Email = goestor.Email,
                Numero = endereco.Numero,
                Rua = endereco.Rua,
                Curriculo = goestor.Curriculo
            };
            return retorno;
        }

        IList<GestorDTO> IGestorApplication.ListarNaoAnalisadosEAprovados()
        {
            IList<GestorDTO> retorno = null;
            var data = _gestorRepositorio.ListarNaoAnalisadosEReprovados();

            retorno = data.Select(x =>  new GestorDTO {Id = x.Id, Nome = x.Nome, Email = x.Email, DataNascimento = x.DataNascimento}).ToList();

            return retorno;
        }

        IList<GestorDTO> IGestorApplication.ListarPorAnalise(bool analisado)
        {
            IList<GestorDTO> retorno = null;
            var data = _gestorRepositorio.ListarPorAnalise(analisado);

            retorno = data.Select(x =>  new GestorDTO {Id = x.Id, Nome = x.Nome, Email = x.Email, DataNascimento = x.DataNascimento}).ToList();

            return retorno;
        }

        IList<GestorDTO> IGestorApplication.ListarPorAprovacao(bool aprovado)
        {
            IList<GestorDTO> retorno = null;
            var data = _gestorRepositorio.ListarPorAprovacao(aprovado);

            retorno = data.Select(x =>  new GestorDTO {Id = x.Id, Nome = x.Nome, Email = x.Email, DataNascimento = x.DataNascimento,
                                                       }).ToList();

            return retorno;
        }
    }
}