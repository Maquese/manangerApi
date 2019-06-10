using System;
using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Application.Enums;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IBeneficiarioApplication
    {
        public void Adicionar(int idContratante, string nome, DateTime dataNascimento, int sexo, string telefone, string estado,
                              int cidade, string bairro, string rua, string numero, string cep, string complemento,
                              IList<int> condicoesClinicas, bool termos)
        {
            var Beneficiario = new Beneficiario
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Sexo = sexo,
                Telefone = telefone,
                EstadoId = _estadoRepostorio.IdPorUf(estado),
                CidadeId =  cidade,
                Bairro = bairro,
                Rua = rua,
                BeneficiarioCondicaoClinica = new List<BeneficiarioCondicaoClinica>(),
                Numero = numero,
                Cep = cep,
                Complemento = complemento,
                TermoDeResponsalidade = termos,
                Status = (int)StatusEnum.Ativo,
                ContratanteId = idContratante
            };

            foreach (var item in condicoesClinicas)
            {
                Beneficiario.BeneficiarioCondicaoClinica.Add(new BeneficiarioCondicaoClinica{ CondicaoClinicaId = item, Status = (int)StatusEnum.Ativo } );
            }

            _beneficiarioRepositorio.Insert(Beneficiario);
            _beneficiarioRepositorio.Save();
        }

        public void Editar(int idBeneficiario, string nome, DateTime dataNascimento, int sexo, string telefone, string estado,
                              int cidade, string bairro, string rua, string numero, string cep, string complemento,
                              IList<int> condicoesClinicas, bool termos)
        {
            
             var beneficiario = _beneficiarioRepositorio.Encontrar(idBeneficiario);
              beneficiario.Nome = nome;
              beneficiario.DataNascimento = dataNascimento;
              beneficiario.Sexo = sexo;
              beneficiario.Telefone = telefone;
              beneficiario.EstadoId = _estadoRepostorio.IdPorUf(estado);
              beneficiario.CidadeId = cidade;
              beneficiario.Bairro = bairro;
              beneficiario.Rua = rua;
              beneficiario.Numero = numero;
              beneficiario.Cep = cep;
              beneficiario.Complemento = complemento;
              beneficiario.TermoDeResponsalidade = termos;
              
              var condicoes = _beneficiarioCondicaoClinicaRepositorio.EncontrarPorBeneficiarioId(beneficiario.Id);

              foreach (var item in condicoes)
              {
                  item.Status = (int)StatusEnum.Inativo;                
              }

              foreach (var item in condicoesClinicas)
              {
                  var condicao = condicoes.Where(x => x.CondicaoClinicaId == item).FirstOrDefault();

                  if(condicao == null)
                  {
                      _beneficiarioCondicaoClinicaRepositorio.Insert(new BeneficiarioCondicaoClinica
                                                                        { 
                                                                            CondicaoClinicaId = item, 
                                                                            BeneficiarioId = beneficiario.Id,
                                                                            Status = (int)StatusEnum.Ativo
                                                                             });
                  }else{
                      condicao.Status = (int)StatusEnum.Ativo;
                  }
              }

              _beneficiarioRepositorio.Update(beneficiario);
              _beneficiarioRepositorio.Save();
        }

        public BeneficiarioDTO EncontrarPorId(int idBeneficiario)
        {
            var beneficiario =  _beneficiarioRepositorio.Encontrar(idBeneficiario);
            var retorno = new BeneficiarioDTO {
               Nome = beneficiario.Nome,
               Estado = _estadoRepostorio.Encontrar(beneficiario.EstadoId).Uf,
               Cidade = beneficiario.CidadeId,
               Bairro = beneficiario.Bairro,
               Rua = beneficiario.Rua,
               Numero = beneficiario.Numero,
               Cep = beneficiario.Cep,
               Complemento = beneficiario.Complemento,
               DataNascimento = beneficiario.DataNascimento,
               CondicoesClinicas = _beneficiarioCondicaoClinicaRepositorio.EncontrarPorBeneficiarioId(idBeneficiario).Select(x => x.CondicaoClinicaId).ToList(),
               TermoDeResponsalidade = beneficiario.TermoDeResponsalidade,
               Telefone = beneficiario.Telefone,
               Sexo = beneficiario.Sexo,
               Id = beneficiario.Id,
               ContratanteId = beneficiario.ContratanteId
               };
            return retorno;
        }

        public IList<BeneficiarioListaDTO> ListarPorContratante(int idContratante)
        {
            return _beneficiarioRepositorio.ListarPorContratante(idContratante).Select(x => new
            BeneficiarioListaDTO
            {
                Nome = x.Nome,
                Id = x.Id,
                DataNascimento = x.DataNascimento,
                Cidade = _cidadeRepositorio.Encontrar(x.CidadeId).Nome,
                Bairro = x.Bairro,
                Sexo = x.Sexo
            }).ToList();

        }
    }
}