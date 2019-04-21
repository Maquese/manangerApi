using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IContratanteRepositorio : IRepositorio<Contratante>
    {
         IList<Contratante> ListarPorAnalise(bool analisado);

        IList<Contratante> ListarNaoAnalisadosEReprovados();

        IList<Contratante> ListarPorAprovacao(bool aprovado);
         
    }
}