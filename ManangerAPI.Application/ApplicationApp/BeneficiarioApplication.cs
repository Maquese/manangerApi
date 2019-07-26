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

        public void AdicionarMedicamento(int idBeneficiario, int idMedicamento, int idPosologia, int quantidade)
        {
            BeneficiarioMedicamento medicamento = new BeneficiarioMedicamento
            {
                BeneficiarioId = idBeneficiario,
                MedicamentoId = idMedicamento,
                PosologiaId = idPosologia,
                Quantidade = quantidade,
                Status = (int)StatusEnum.Ativo
            };

            _beneficiarioMedicamentoRepositorio.Insert(medicamento);
            _beneficiarioMedicamentoRepositorio.Save();
        }

        public BeneficiarioMedicamentoDTO DetalharBeneficiarioMedicamento(int idBeneficiarioMedicamento)
        {
            var dados = _beneficiarioMedicamentoRepositorio.Encontrar(idBeneficiarioMedicamento);
            return new BeneficiarioMedicamentoDTO {
                Id = dados.Id,
                MedicamentoId = dados.MedicamentoId,
                PosologiaId = dados.PosologiaId,
                Quantidade = dados.Quantidade
            };
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

        public void EditarBeneficiarioMedicamento(int id, int idMedicamento, int idPosologia, int quantidade)
        {
            var dados = _beneficiarioMedicamentoRepositorio.Encontrar(id);
            dados.MedicamentoId = idMedicamento;
            dados.PosologiaId = idPosologia;
            dados.Quantidade = quantidade;
            _beneficiarioMedicamentoRepositorio.Update(dados);
            _beneficiarioMedicamentoRepositorio.Save();
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

        public IList<BeneficiarioMedicamentoListaDTO> ListarBeneficiarioMedicamento(int idBeneficiario)
        {
            var medicamentos = _beneficiarioMedicamentoRepositorio.ListarPorBeneficiarioId(idBeneficiario);

            var retorno = new List<BeneficiarioMedicamentoListaDTO>();
            foreach (var item in medicamentos)
            {
                retorno.Add(new BeneficiarioMedicamentoListaDTO
                {
                    Id = item.Id,
                    NomeMedicamento = _medicamentoRepositorio.NomeMedicamento(item.MedicamentoId),
                    Posologia = _posologiaRepositorio.Encontrar(item.PosologiaId).Nome,
                    Quantidade = item.Quantidade
                });
            }
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

        public void RemoverBeneficiarioMedicamento(int id)
        {
            var medicamento = _beneficiarioMedicamentoRepositorio.Encontrar(id);
            medicamento.Status = 2;
            _beneficiarioMedicamentoRepositorio.Save();
        }
    }
}