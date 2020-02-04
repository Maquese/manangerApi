using ManangerAPI.Application.Contratos;
using ManangerAPI.Data.Entidades;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IContatoApplication
    {
        public int CriarNovo(string nome, string email, int tipoContato, string observacoes)
        {
            var contato = new Contato{ Nome = nome, Email = email, TipoContatoId = tipoContato,  Comentario = observacoes };
            _contatoRepositorio.Insert(contato);
            _contatoRepositorio.Save();

            return contato.Id;
        }
    }
}