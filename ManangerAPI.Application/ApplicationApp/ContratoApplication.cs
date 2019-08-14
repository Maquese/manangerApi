using ManangerAPI.Application.Contratos;
using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IContratoApplication
    {
        public DadosSolicitacaoContratoDTO BuscarDadosSolicitacaoContrato(int idContratante, int idPrestador, int idBeneficiario)
        {
            var retorno = new DadosSolicitacaoContratoDTO();
            var nomeContratante = _contratanteRepositorio.Encontrar(idContratante).Nome;
            var nomeBeneficiario = _beneficiarioRepositorio.Encontrar(idContratante).Nome;
            var nomePrestador = _prestadorDeServicoRepositorio.Encontrar(idContratante).Nome;

            retorno.NomeBeneficiario = nomeBeneficiario;
            retorno.NomeContratante = nomeContratante;
            retorno.NomePrestadorDeServico = nomePrestador;

            return retorno;            
        }
    }
}