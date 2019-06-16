using System;
using System.Collections.Generic;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IBeneficiarioApplication
    {
        void Deletar(int Id);
        void Adicionar(int idContratante, string nome, DateTime dataNascimento, int sexo, string telefone, string estado, int cidade,
                       string bairro, string rua, string numero, string cep, string complemento, IList<int> condicoesClinicas, bool termos);
        IList<BeneficiarioListaDTO> ListarPorContratante(int idContratante);
        void Editar(int idBeneficiario, string nome, DateTime dataNascimento, int sexo, string telefone, string estado,
                             int cidade, string bairro, string rua, string numero, string cep, string complemento,
                             IList<int> condicoesClinicas, bool termos);
        BeneficiarioDTO EncontrarPorId(int idBeneficiario);

        void AdicionarMedicamento(int idBeneficiario, int idMedicamento, int idPosologia, int quantidade);

        IList<BeneficiarioMedicamentoListaDTO> ListarBeneficiarioMedicamento(int idBeneficiario);  

        BeneficiarioMedicamentoDTO DetalharBeneficiarioMedicamento(int idBeneficiarioMedicamento);

        void EditarBeneficiarioMedicamento(int id, int idMedicamento, int idPosologia, int quantidade);

    }
}