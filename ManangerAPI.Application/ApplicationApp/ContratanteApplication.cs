using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IContratanteApplication
    {
        public void Cadastrar(string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,string cidade,string estado,string bairro,string cep,
                        string numero,string complemento, string rua)
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
                Status = 0,
                Endereco = new Endereco 
                {
                    Estado = estado,
                    Cidade = cidade,
                    Bairro = bairro,
                    Cep = cep,
                    Numero = numero,
                    Complemento = complemento,
                    Rua = rua,
                    Status = 0
                }
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