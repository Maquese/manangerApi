using System.Linq;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class EnderecoRepositorio : Repositorio<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(ContextoDb contexto) : base(contexto)
        {
        }

        public Endereco EncontrarPorUsuario(int idUsuario)
        {
            return _contexto.Endereco.Where(x =>x.UsuarioId == idUsuario).FirstOrDefault();
        }
    }
}