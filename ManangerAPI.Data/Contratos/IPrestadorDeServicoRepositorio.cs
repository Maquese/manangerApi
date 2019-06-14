using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IPrestadorDeServicoRepositorio : IRepositorio<PrestadorDeServico>
    {
          IList<PrestadorDeServico> ListarPorAnalise(bool analisado);

          IList<PrestadorDeServico> ListarNaoAnalisadosEReprovados();
          
        IList<PrestadorDeServico> ListarPorAprovacao(bool aprovado);

        IList<PrestadorDeServico> ListarPrestadoresProximos(int cidadeId);
    }
}