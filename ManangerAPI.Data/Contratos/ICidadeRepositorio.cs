using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface ICidadeRepositorio : IRepositorio<Cidade>
    {
         IList<KeyValuePair<int,string>> GerarDropDown();

         IList<KeyValuePair<int,string>> GerarDropDown(string uf);

         int EncotrarIdPorNome(string nome);
    }
}