using ManangerAPI.Application.Contratos;
using ManangerAPI.Data.Contratos;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IApplication
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IContratanteRepositorio _contratanteRepositorio;
        private readonly IAdministradorRepositorio _administradorRepositorio;

        public Application(IUsuarioRepositorio usuarioRepositorio, IAdministradorRepositorio administradorRepositorio, IContratanteRepositorio contratanteRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _contratanteRepositorio = contratanteRepositorio;
            _administradorRepositorio = administradorRepositorio;
        }
    }
}