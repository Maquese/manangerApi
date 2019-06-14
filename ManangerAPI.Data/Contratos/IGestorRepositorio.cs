using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IGestorRepositorio : IRepositorio<Gestor>
    {
         IList<Gestor> ListarPorAnalise(bool analisado);
         IList<Gestor> ListarNaoAnalisadosEReprovados();
         
        IList<Gestor> ListarPorAprovacao(bool aprovado);

        IList<Gestor> ListarGestoresProximos(int cidadeId);
    }
}