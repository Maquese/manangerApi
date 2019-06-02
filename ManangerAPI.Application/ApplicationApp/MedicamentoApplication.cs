using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;
using ManangerAPI.Application.Enums;
using ManangerAPI.Data.Entidades;
namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IMedicamentoApplication
    {
        public void Cadastrar(int idBeneficiario, string nome, string contraIndicacao, string bula, string indicacao, int tipo, int viaDeUso, string efeitoColateral)
        {
            var Medicamento = new Medicamento{BeneficiarioId = idBeneficiario, Nome = nome, ContraIndicacao = contraIndicacao, Bula = bula, 
                                              Indicao = indicacao, Tipo = tipo, ViaDeUso = viaDeUso, EfeitoColateral = efeitoColateral , Status = (int)StatusEnum.Ativo };
            _medicamentoRepositorio.Insert(Medicamento);
            _medicamentoRepositorio.Save();
        }

        public MedicamentoDTO Detalhar(int idBeneficiario)
        {
            var medicamento = _medicamentoRepositorio.Encontrar(idBeneficiario);

            return new MedicamentoDTO
            {
                IdMedicamento = medicamento.Id,
                Nome = medicamento.Nome,
                Bula = medicamento.Bula,
                ContraIndicacao = medicamento.ContraIndicacao,
                EfeitoColateral = medicamento.EfeitoColateral,
                Indicao = medicamento.Indicao, 
                Tipo = medicamento.Tipo,
                ViaDeUso = medicamento.ViaDeUso,
            };
        }

        public void Editar(int idMedicamento, string nome, string contraIndicacao, string bula, string indicacao, int tipo, int viaDeUso, string efeitoColateral)
        {
            var Medicamento =_medicamentoRepositorio.Encontrar(idMedicamento);

            Medicamento.Nome = nome;
            Medicamento.ContraIndicacao = contraIndicacao;
            Medicamento.Bula = bula;
            Medicamento.Indicao = indicacao;
            Medicamento.Tipo = tipo;
            Medicamento.ViaDeUso = viaDeUso;
            Medicamento.EfeitoColateral = efeitoColateral;

            _medicamentoRepositorio.Update(Medicamento);
            _medicamentoRepositorio.Save();
        }

        public IList<MedicamentoListaDTO> Listar(int idBeneficiario)
        {
            return _medicamentoRepositorio.ListarPorBeneficiario(idBeneficiario).Select(x => new MedicamentoListaDTO
            {
                Id = x.Id,
                Nome = x.Nome
            }).ToList();
        }

        public void Remover(int idMedicamento)
        {
            _medicamentoRepositorio.LogicDelete(_medicamentoRepositorio.Encontrar(idMedicamento));
            _medicamentoRepositorio.Save();
        }
    }
}