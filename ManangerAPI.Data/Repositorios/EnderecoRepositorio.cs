using System.Linq;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Repositorios
{
    public class EnderecoRepositorio : Repositorio<Endereco>, IEnderecoRepositorio
    {
        public Endereco EncontrarPorUsuario(int idUsuario)
        {
            return _contexto.Endereco.Where(x =>x.UsuarioId == idUsuario).FirstOrDefault();
        }
    }
}