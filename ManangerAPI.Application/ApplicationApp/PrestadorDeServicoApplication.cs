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
                              string telefone, int cidade, string estado, string bairro, string cep, string rua, string numero, 
                              string complemento, IList<int> competencias, string comentario, bool termos, string imagem)
        {
            PrestadorDeServico prestadorServico = new PrestadorDeServico{
                Imagem = imagem,
                Nome = nome,
                Login = login,
                Senha = senha,
                Email = email,
                DataNascimento = dataNascimento,
                Sexo = sexo,
                Cpf = cpf,
                Telefone = telefone,
                Status = (int)StatusEnum.Ativo,                
                PrestadorDeServicoCompetencia = new List<PrestadorDeServicoCompetencia>(),
                Comentario = comentario,
                Termos = termos,
                Endereco = new Endereco
                {
                    EstadoId = _estadoRepostorio.IdPorUf(estado),
                    CidadeId = cidade,
                    Bairro = bairro,
                    Rua = rua,
                    Numero = numero,
                    Complemento = complemento,
                    Status = (int)StatusEnum.Ativo,
                    Cep = cep
                },
                Acessos = new List<Acesso>{new Acesso{PerfilId = (int)PerfilEnum.PrestadorDeServico, Status = (int)StatusEnum.Ativo}
                
                }
            };

            foreach (var item in competencias)
            {
                prestadorServico.PrestadorDeServicoCompetencia.Add(new PrestadorDeServicoCompetencia
                {
                    CompetenciaId = item,
                    Status = (int)StatusEnum.Ativo
                });
            }
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
                                                                   DataNascimento = x.DataNascimento}).ToList();

            return retorno;
        }
    }
}