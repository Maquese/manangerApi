using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Application.Enums;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IPrestadorDeServicoApplication
    {
        public void Cadastrar(string nome, string login, string senha, string email, DateTime dataNascimento, int sexo, string cpf, 
                              string telefone, string cidade, string estado, string bairro, string cep, string rua, string numero, 
                              string complemento, string competencias, string comentario, bool termos)
        {
            PrestadorDeServico prestadorServico = new PrestadorDeServico{
                Nome = nome,
                Login = login,
                Senha = senha,
                Email = email,
                DataNascimento = dataNascimento,
                Sexo = sexo,
                Cpf = cpf,
                Telefone = telefone,
                Status = (int)StatusEnum.Ativo,
                Competencias = competencias,
                Comentario = comentario,
                Termos = termos,
                Endereco = new Endereco
                {
                    Estado = estado,
                    Cidade = cidade,
                    Bairro = bairro,
                    Rua = rua,
                    Numero = numero,
                    Complemento = complemento,
                    Status = (int)StatusEnum.Ativo,
                    Cep = cep
                },
                Acessos = new List<Acesso>{new Acesso{PerfilId = (int)PerfilEnum.PrestadorDeServico, Status = (int)StatusEnum.Ativo} }
            };
            _prestadorDeServicoRepositorio.Insert(prestadorServico);
            _prestadorDeServicoRepositorio.Save();
        }

        IList<PrestadorDeServicoDTO> IPrestadorDeServicoApplication.ListarNaoAnalisadosEAprovados()
        {
            throw new NotImplementedException();
        }

        IList<PrestadorDeServicoDTO> IPrestadorDeServicoApplication.ListarPorAnalise(bool analisado)
        {
             IList<PrestadorDeServicoDTO> retorno = null;
            var data = _prestadorDeServicoRepositorio.ListarPorAnalise(analisado);

            retorno = data.Select(x =>  new PrestadorDeServicoDTO {Id = x.Id, Nome = x.Nome, Email = x.Email, DataNascimento = x.DataNascimento}).ToList();

            return retorno;
        }

        IList<PrestadorDeServicoDTO> IPrestadorDeServicoApplication.ListarPorAprovacao(bool aprovado)
        {
            IList<PrestadorDeServicoDTO> retorno = null;
            var data = _prestadorDeServicoRepositorio.ListarPorAprovacao(aprovado);

            retorno = data.Select(x =>  new PrestadorDeServicoDTO {Id = x.Id, Nome = x.Nome, Email = x.Email,
                                                                   DataNascimento = x.DataNascimento, Competencias = x.Competencias}).ToList();

            return retorno;
        }
    }
}