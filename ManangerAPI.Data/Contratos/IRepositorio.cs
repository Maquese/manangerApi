using System.Collections.Generic;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IRepositorio<T> where T: EntidadeBase
    {
         void Insert(T document);

         IList<T> Listar();

         T Encontrar(int onde);
         void InsertMany(IList<T> documents);

         void Update( T document);

         void Save();

         void LogicDelete(T document);
    }
}