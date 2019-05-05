using System;
using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IBeneficiarioApplication
    {
        void Deletar(int Id);
        void Adicionar(int idContratante, string nome, DateTime dataNascimento, int sexo, string telefone, string estado, string cidade,
                       string bairro, string rua, string numero, string cep, string complemento, string condicoesClinicas, bool termos);
        IList<BeneficiarioListaDTO> ListarPorContratante(int idContratante);
        void Editar(int idBeneficiario, string nome, DateTime dataNascimento, int sexo, string telefone, string estado,
                             string cidade, string bairro, string rua, string numero, string cep, string complemento,
                             string condicoesClinicas, bool termos);
        BeneficiarioDTO EncontrarPorId(int idBeneficiario);
    }
}