using System.Collections.Generic;
using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ManangerAPI.Data.Repositorios
{
    public class GestorRepositorio : Repositorio<Gestor>, IGestorRepositorio
    {
        public GestorRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public IList<Gestor> ListarGestoresProximos(int cidadeId)
        {
            return _contexto.Gestor.Include("Endereco").Where(x => x.Endereco.CidadeId == cidadeId).ToList();
        }

        public IList<Gestor> ListarNaoAnalisadosEReprovados()
        {
            return _contexto.Gestor.Where(x => x.Aprovado  && x.Status == 1).ToList();
        }

        public IList<Gestor> ListarPorAnalise(bool analisado)
        {
            return _contexto.Gestor.Where(x => x.Analisado == analisado && x.Status == 1).ToList();
        }

        public IList<Gestor> ListarPorAprovacao(bool aprovado)
        {
             return _contexto.Gestor.Where(x => x.Aprovado == aprovado && x.Status == 1).ToList();
        }
    }
}