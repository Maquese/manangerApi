using ManangerAPI.Application.DTOS;

namespace ManangerAPI.Application.Contratos
{
    public interface IContratoApplication
    {
         DadosSolicitacaoContratoDTO BuscarDadosSolicitacaoContrato(int idContratante, int idPrestador, int idBeneficiario);
    }
}