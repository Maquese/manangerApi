using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Application.Enums;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IContratanteApplication
    {
        public UsuarioEditDTO BuscarContratantePorId(int id)
        {
            var contratante = _contratanteRepositorio.Encontrar(id);
            var endereco = _enderecoRepositorio.EncontrarPorUsuario(id);
            var retorno = new UsuarioEditDTO{
                Id  = contratante.Id,
                Nome = contratante.Nome,
                DataNascimento = contratante.DataNascimento,
                Login = contratante.Login,
                Termos = contratante.Termos,
                Sexo = contratante.Sexo,
                Imagem = contratante.Imagem,
                Comentario = contratante.Comentario,
                Senha = contratante.Senha,
                Telefone = contratante.Telefone,
                Estado = _estadoRepostorio.Encontrar(endereco.EstadoId).Uf,
                Cidade = endereco.CidadeId,
                Bairro = endereco.Bairro,
                Cep = endereco.Cep,
                Complemento = endereco.Complemento,
                Cpf = contratante.Cpf,
                Email = contratante.Email,
                Numero = endereco.Numero,
                Rua = endereco.Rua
            };
            return retorno;
        }

        public void Cadastrar(string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,int cidade,string estado,string bairro,string cep,
                        string numero,string complemento, string rua, string imagem)
        {

            Contratante contratante = new Contratante
            {   
                Nome = nome,
                Login = login,
                Senha = senha,
                Email = email,
                DataNascimento = dataNascimento,
                Sexo = sexo,
                Cpf = cpf,
                Telefone = telefone,
                Comentario = comentarios,
                Termos = termos,
                Status = (int)StatusEnum.Ativo,
                Imagem = imagem,
                Endereco = new Endereco 
                {
                    EstadoId = _estadoRepostorio.IdPorUf(estado),
                    CidadeId = cidade,
                    Bairro = bairro,
                    Cep = cep,
                    Numero = numero,
                    Complemento = complemento,
                    Rua = rua,
                    Status = (int)StatusEnum.Ativo
                },
                Acessos = new List<Acesso>{new Acesso{PerfilId = (int)PerfilEnum.Contratante, Status = (int)StatusEnum.Ativo} }
            };
            _contratanteRepositorio.Insert(contratante);
            _contratanteRepositorio.Save();
        }

        public ContratanteDTO DetalharContratante(int idContratante)
        {
            throw new System.NotImplementedException();
        }

        public IList<ContratanteDTO> ListarNaoAnalisadosEAprovados()
        {
            IList<ContratanteDTO>  retorno = null;
            var data = _contratanteRepositorio.ListarNaoAnalisadosEReprovados();

            retorno = data.Select(x => new ContratanteDTO {Id = x.Id, Nome = x.Nome, Email = x.Email, DataNascimento = x.DataNascimento }).ToList();

            return retorno;
        }

        public IList<ContratanteDTO> ListarPorAnalise(bool analisado)
        {
            IList<ContratanteDTO>  retorno = null;
            var data = _contratanteRepositorio.ListarPorAnalise(analisado);

            retorno = data.Select(x => new ContratanteDTO {Id = x.Id, Nome = x.Nome, Email = x.Email, DataNascimento = x.DataNascimento }).ToList();

            return retorno;
        }

        public IList<ContratanteDTO> ListarPorAprovacao(bool aprovado)
        {
            IList<ContratanteDTO>  retorno = null;
            var data = _contratanteRepositorio.ListarPorAprovacao(aprovado);

            retorno = data.Select(x => new ContratanteDTO {Id = x.Id, Nome = x.Nome, Email = x.Email, DataNascimento = x.DataNascimento }).ToList();

            return retorno;
        }
    }
}