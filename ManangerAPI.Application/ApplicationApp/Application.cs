using ManangerAPI.Application.Contratos;
using ManangerAPI.Data.Contratos;

namespace ManangerAPI.Application.ApplicationApp
{
    public partial class Application : IApplication
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IContratanteRepositorio _contratanteRepositorio;
        private readonly IAdministradorRepositorio _administradorRepositorio;
        private readonly IPrestadorDeServicoRepositorio _prestadorDeServicoRepositorio;
        private readonly IGestorRepositorio _gestorRepositorio;
        private readonly IFuncionalidadeRepositorio _funcionalidadeRepositorio;
        private readonly IAcessoRepositorio _acessoRepositorio;
        private readonly IBeneficiarioRepositorio _beneficiarioRepositorio;

        public Application(IUsuarioRepositorio usuarioRepositorio, IAdministradorRepositorio administradorRepositorio, 
                           IContratanteRepositorio contratanteRepositorio, IPrestadorDeServicoRepositorio prestadorDeServicoRepositorio,
                           IGestorRepositorio gestorRepositorio, IFuncionalidadeRepositorio funcionalidadeRepositorio,
                           IAcessoRepositorio acessoRepositorio, IBeneficiarioRepositorio beneficiarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _contratanteRepositorio = contratanteRepositorio;
            _administradorRepositorio = administradorRepositorio;
            _prestadorDeServicoRepositorio = prestadorDeServicoRepositorio;
            _gestorRepositorio = gestorRepositorio;
            _funcionalidadeRepositorio = funcionalidadeRepositorio;
            _acessoRepositorio = acessoRepositorio;
            _beneficiarioRepositorio = beneficiarioRepositorio;
        }
    }
}