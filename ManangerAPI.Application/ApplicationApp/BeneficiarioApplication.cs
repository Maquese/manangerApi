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
                              string cidade, string bairro, string rua, string numero, string cep, string complemento,
                              string condicoesClinicas, bool termos)
        {
            var Beneficiario = new Beneficiario
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Sexo = sexo,
                Telefone = telefone,
                Estado = estado,
                Cidade = cidade,
                Bairro = bairro,
                Rua = rua,
                Numero = numero,
                Cep = cep,
                Complemento = complemento,
                CondicoesClinicas = condicoesClinicas,
                TermoDeResponsalidade = termos,
                Status = (int)StatusEnum.Ativo,
                ContratanteId = idContratante
            };
            _beneficiarioRepositorio.Insert(Beneficiario);
            _beneficiarioRepositorio.Save();
        }

        public void Editar(int idBeneficiario, string nome, DateTime dataNascimento, int sexo, string telefone, string estado,
                              string cidade, string bairro, string rua, string numero, string cep, string complemento,
                              string condicoesClinicas, bool termos)
        {
            
             var beneficiario = _beneficiarioRepositorio.Encontrar(idBeneficiario);
              beneficiario.Nome = nome;
              beneficiario.DataNascimento = dataNascimento;
              beneficiario.Sexo = sexo;
              beneficiario.Telefone = telefone;
              beneficiario.Estado = estado;
              beneficiario.Cidade = cidade;
              beneficiario.Bairro = bairro;
              beneficiario.Rua = rua;
              beneficiario.Numero = numero;
              beneficiario.Cep = cep;
              beneficiario.Complemento = complemento;
              beneficiario.CondicoesClinicas = condicoesClinicas;
              beneficiario.TermoDeResponsalidade = termos;
              _beneficiarioRepositorio.Update(beneficiario);
              _beneficiarioRepositorio.Save();
        }

        public BeneficiarioDTO EncontrarPorId(int idBeneficiario)
        {
            var beneficiario =  _beneficiarioRepositorio.Encontrar(idBeneficiario);
            return new BeneficiarioDTO {
               Nome = beneficiario.Nome,
               Estado = beneficiario.Estado,
               Cidade = beneficiario.Cidade,
               Bairro = beneficiario.Bairro,
               Rua = beneficiario.Rua,
               Numero = beneficiario.Numero,
               Cep = beneficiario.Cep,
               Complemento = beneficiario.Complemento,
               DataNascimento = beneficiario.DataNascimento,
               CondicoesClinicas = beneficiario.CondicoesClinicas,
               TermoDeResponsalidade = beneficiario.TermoDeResponsalidade,
               Telefone = beneficiario.Telefone,
               Sexo = beneficiario.Sexo,
               Id = beneficiario.Id,
               ContratanteId = beneficiario.ContratanteId
               };
        }

        public IList<BeneficiarioListaDTO> ListarPorContratante(int idContratante)
        {
            return _beneficiarioRepositorio.ListarPorContratante(idContratante).Select(x => new
            BeneficiarioListaDTO
            {
                Nome = x.Nome,
                Id = x.Id,
                DataNascimento = x.DataNascimento,
                CondicoesClinicas = x.CondicoesClinicas,
                Sexo = x.Sexo
            }).ToList();

        }
    }
}