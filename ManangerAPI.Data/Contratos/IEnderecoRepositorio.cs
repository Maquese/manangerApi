using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Data.Contratos
{
    public interface IEnderecoRepositorio : IRepositorio<Endereco>
    {
         Endereco EncontrarPorUsuario(int idUsuario);
    }
}