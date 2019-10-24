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
        public void AceitarOuNaoSolicitacao(int idSolicitacao, bool aceitou)
        {
            var solicitacao = _solicitacaoContratoRepositorio.Encontrar(idSolicitacao);
            
            if(solicitacao != null)
            {
                var nomePrestador = _prestadorDeServicoRepositorio.Encontrar(solicitacao.PrestadorDeServicoId).Nome;
                var contratante = _contratanteRepositorio.Encontrar(solicitacao.ContratanteId);
                solicitacao.DataFim = DateTime.Now;
                if (aceitou)
                {
                    var contrato = new Contrato
                    {
                        BeneficiarioId = solicitacao.BeneficiarioId,
                        ContratanteId = solicitacao.ContratanteId,
                        SolicitacaoContratoId = solicitacao.Id,
                        DataInicio = DateTime.Now,
                        PrestadorDeServicoId = solicitacao.PrestadorDeServicoId,
                        Status = (int)StatusEnum.Ativo,
                        
                    };
                    _contratoRepositorio.Insert(contrato);
                    EnviarEmailRespostaSolicitacaoContrato(nomePrestador,contratante.Email,contratante.Nome);
                }                
                    _contratoRepositorio.Save();
            }
        }

        public UsuarioEditDTO BuscarPrestadorPorId(int id)
        {
              var prestador = _prestadorDeServicoRepositorio.Encontrar(id);
            var endereco = _enderecoRepositorio.EncontrarPorUsuario(id);
            var retorno = new UsuarioEditDTO{
                Id  = prestador.Id,
                Nome = prestador.Nome,
                DataNascimento = prestador.DataNascimento,
                Login = prestador.Login,
                Termos = prestador.Termos,
                Sexo = prestador.Sexo,
                Imagem = prestador.Imagem,
                Comentario = prestador.Comentario,
                Senha = prestador.Senha,
                Telefone = prestador.Telefone,
                Estado = _estadoRepostorio.Encontrar(endereco.EstadoId).Uf,
                Cidade = endereco.CidadeId,
                Bairro = endereco.Bairro,
                Cep = endereco.Cep,
                Complemento = endereco.Complemento,
                Cpf = prestador.Cpf,
                Email = prestador.Email,
                Numero = endereco.Numero,
                Rua = endereco.Rua,
                Curriculo  =  prestador.Curriculo,
                Competencias = _prestadorDeServicoCompetenciaRepositorio.EncontrarPorPrestadorDeServicoId(prestador.Id).Select(x => x.CompetenciaId).ToList()
            };
            return retorno;
        }

        public void Cadastrar(string nome, string login, string senha, string email, DateTime dataNascimento, int sexo, string cpf, 
                              string telefone, int cidade, string estado, string bairro, string cep, string rua, string numero, 
                              string complemento, IList<int> competencias, string comentario, bool termos, string imagem,string pdf)
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
                Curriculo = pdf,
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

        public void EditarPrestadorDeServico(int id, string nome, string login, string senha, string email, DateTime dataNascimento, 
                                             int sexo, string cpf, string telefone, int cidade, string estado, string bairro, string cep,
                                             string rua, string numero, string complemento, IList<int> competencias, string comentario,
                                             bool termos, string imagem, string Curriculo)
        {
            var prestadorDeServico = _prestadorDeServicoRepositorio.Encontrar(id);
            prestadorDeServico.Nome = nome;
            prestadorDeServico.Login = login;
            prestadorDeServico.Senha = senha;
            prestadorDeServico.Email = email;
            prestadorDeServico.DataNascimento = dataNascimento;
            prestadorDeServico.Sexo = sexo;
            prestadorDeServico.Cpf = cpf;
            prestadorDeServico.Telefone = telefone;
            prestadorDeServico.Comentario = comentario;
            prestadorDeServico.Termos = termos;
            prestadorDeServico.Imagem = imagem;
            prestadorDeServico.Curriculo = Curriculo;

            var endereco = _enderecoRepositorio.EncontrarPorUsuario(id);
            endereco.EstadoId = _estadoRepostorio.IdPorUf(estado);
            endereco.CidadeId = cidade;
            endereco.Bairro = bairro;
            endereco.Cep  = cep;
            endereco.Rua = rua;
            endereco.Numero = numero;
            endereco.Complemento = complemento;


            var prestadorCompetencia = _prestadorDeServicoCompetenciaRepositorio.EncontrarPorPrestadorDeServicoId(id);

              foreach (var item in prestadorCompetencia)
              {
                  item.Status = (int)StatusEnum.Inativo;                
              }

              foreach (var item in competencias)
              {
                  var condicao = prestadorCompetencia.Where(x => x.CompetenciaId == item).FirstOrDefault();

                  if(condicao == null)
                  {
                      _prestadorDeServicoCompetenciaRepositorio.Insert(new PrestadorDeServicoCompetencia
                                                                        { 
                                                                            CompetenciaId = item, 
                                                                            PrestadorDeServicoId = id,
                                                                            Status = (int)StatusEnum.Ativo
                                                                             });
                  }else{
                      condicao.Status = (int)StatusEnum.Ativo;
                  }
              }
              _prestadorDeServicoRepositorio.Update(prestadorDeServico);
              _enderecoRepositorio.Update(endereco);
              _prestadorDeServicoCompetenciaRepositorio.Save();


        }

        public IList<ListagemPrestadorGestorDTO> ListarPrestadoresProximos(int cidadeId)
        {
             return _prestadorDeServicoRepositorio.ListarPrestadoresProximos(cidadeId).Select(x => new ListagemPrestadorGestorDTO
            {
                Id = x.Id,
                DataNascimento = x.DataNascimento,
                Imagem = x.Imagem,
                Nome = x.Nome,
                Telefone = x.Telefone
            }).ToList();
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

        IList<SolicitacaoPendentePrestadorDTO> IPrestadorDeServicoApplication.ListarSolicitacoesPendentes(int idPrestador)
        {
            var retorno = new List<SolicitacaoPendentePrestadorDTO>();
            foreach (var item in  _solicitacaoContratoRepositorio.ListarSolicitacoesPorPrestador(idPrestador))
            {
                retorno.Add(new SolicitacaoPendentePrestadorDTO{
                    Id  = item.Id,
                    DataSolicitacao  = item.DataSolicitacao,
                    NomeBeneficiario = _beneficiarioRepositorio.Encontrar(item.BeneficiarioId).Nome,
                    NomeContratante = _contratanteRepositorio.Encontrar(item.ContratanteId).Nome,
                    BeneficiarioId = item.BeneficiarioId,
                    ContratanteId = item.ContratanteId,
                    TelefonePrestador = _prestadorDeServicoRepositorio.Encontrar(item.PrestadorDeServicoId).Telefone,
                    TelefoneContratante = _contratanteRepositorio.Encontrar(item.ContratanteId).Telefone
                    
                });
            }
            return retorno;            
        }
    }
}