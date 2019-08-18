using System;
using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IContratanteApplication
    {
        void Cadastrar(string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,int cidade,string estado,string bairro,string cep,
                        string numero,string complemento, string rua, string imagem);///entre outras coisas
        void EditarContratante(int id, string nome, string login, string senha, string email,DateTime dataNascimento, int sexo, string cpf,
                        string telefone,string comentarios,bool termos,int cidade,string estado,string bairro,string cep,
                        string numero,string complemento, string rua, string imagem);///entre outras coisas
        IList<ContratanteDTO> ListarPorAnalise(bool analisado);   

        IList<ContratanteDTO> ListarPorAprovacao(bool aprovado); 

        ContratanteDTO DetalharContratante(int idContratante);   

        IList<ContratanteDTO> ListarNaoAnalisadosEAprovados();
            
        UsuarioEditDTO BuscarContratantePorId(int id);

        void SolicitarNovoContrato(int idContratante, int idPrestador, int idBeneficiario,DateTime dataFim, string comentario, bool tempoIndeterminado); 

        DadosSolicitacaoContratoDTO BuscarDadosSolicitacaoContrato(int idBeneficiario, int idContratante, int idPrestador);
    }
}