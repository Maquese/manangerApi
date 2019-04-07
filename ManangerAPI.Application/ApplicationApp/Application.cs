using ManangerAPI.Application.Contratos;
using ManangerAPI.Data.Contratos;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IApplication
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public Application(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
    }
}