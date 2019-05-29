using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : EntidadeBase
    {
        protected readonly ContextoDb _contexto;

        public Repositorio(ContextoDb contexto)
        {
            _contexto = contexto;
        }
        public T Encontrar(int onde)
        {
            return _contexto.Set<T>().Find(onde);
        }

        public void Insert(T entidade)
        {
            _contexto.Set<T>().Add(entidade);
        }

        public void InsertMany(IList<T> entidade)
        {
            _contexto.Set<T>().AddRange(entidade);
        }

        public IList<T> Listar()
        {
            return _contexto.Set<T>().ToList();
        }

        public void LogicDelete(T entidade)
        {
            entidade.Status = 2;
        }

        public void Save()
        {
            _contexto.SaveChanges();
        }

        public void Update( T entidade)
        {
            _contexto.Set<T>().Update(entidade);
        }
    }
}