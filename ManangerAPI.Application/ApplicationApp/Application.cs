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
        private readonly IEnderecoRepositorio _enderecoRepositorio;
        private readonly IMedicamentoRepositorio _medicamentoRepositorio;
        private readonly IEstadoRepositorio _estadoRepostorio;
        private readonly ICidadeRepositorio _cidadeRepositorio;
        private readonly ICompetenciaRepositorio _competenciaRepositorio;
        private readonly ICondicaoClinicaRepositorio _condicaoClinicaRepositorio;
        private readonly IBeneficiarioCondicaoClinicaRepositorio _beneficiarioCondicaoClinicaRepositorio;
        private readonly IPrestadorDeServicoCompetenciaRepositorio _prestadorDeServicoCompetenciaRepositorio;
        private readonly IBeneficiarioMedicamentoRepositorio _beneficiarioMedicamentoRepositorio;
        private readonly IViaDeUsoMedicamentoRepositorio _viaDeUsoMedicamentoRepositorio;
        private readonly ITipoMedicamentoRepositorio _tipoMedicamentoRepositorio;
        private readonly IPosologiaRepositorio _posologiaRepositorio;
        private readonly ISolicitacaoContratoRepositorio _solicitacaoContratoRepositorio;
        private readonly IContratoRepositorio _contratoRepositorio;
        private readonly ITarefaRepositorio _tarefaRepositorio;
        private readonly ITarefaRealizadaRepositorio _tarefaRealizadaRepositorio;
        private readonly IMedicoBeneficiarioRepositorio _medicoBeneficiarioRepositorio;
        private readonly IEspecialidadeMedicaRepositorio _especialidadeMedicaRepositorio;
        private readonly IUnidadeDeMedidaRepositorio _unidadeDeMedidaRepositorio;
        private readonly ITipoContatoRepositorio _tipoContatoRepositorio;
        private readonly IContatoRepositorio _contatoRepositorio;

        public Application(IUsuarioRepositorio usuarioRepositorio, IAdministradorRepositorio administradorRepositorio, 
                           IContratanteRepositorio contratanteRepositorio, IPrestadorDeServicoRepositorio prestadorDeServicoRepositorio,
                           IGestorRepositorio gestorRepositorio, IFuncionalidadeRepositorio funcionalidadeRepositorio,
                           IAcessoRepositorio acessoRepositorio, IBeneficiarioRepositorio beneficiarioRepositorio,
                           IEnderecoRepositorio enderecoRepositorio, IMedicamentoRepositorio medicamentoRepositorio,
                           IEstadoRepositorio estadoRepositorio, ICidadeRepositorio cidadeRepositorio,
                           ICompetenciaRepositorio competenciaRepositorio, ICondicaoClinicaRepositorio condicaoClinicaRepositorio,
                           IBeneficiarioCondicaoClinicaRepositorio beneficiarioCondicaoClinicaRepositorio,
                           IPrestadorDeServicoCompetenciaRepositorio prestadorDeServicoCompetenciaRepositorio, 
                           IBeneficiarioMedicamentoRepositorio beneficiarioMedicamentoRepositorio, ITipoMedicamentoRepositorio tipoMedicamentoRepositorio,
                           IViaDeUsoMedicamentoRepositorio viaDeUsoMedicamentoRepositorio, IPosologiaRepositorio posologiaRepositorio,
                           ISolicitacaoContratoRepositorio solicitacaoContratoRepositorio,IContratoRepositorio contratoRepositorio,
                           ITarefaRepositorio tarefaRepositorio, ITarefaRealizadaRepositorio tarefaRealizadaRepositorio,
                           IMedicoBeneficiarioRepositorio medicoBeneficiarioRepositorio, IEspecialidadeMedicaRepositorio especialidadeMedicaRepositorio,
                           IUnidadeDeMedidaRepositorio unidadeDeMedidaRepositorio, ITipoContatoRepositorio tipoContatoRepositorio, 
                           IContatoRepositorio contatoRepositorio
                           )
        {
            _usuarioRepositorio = usuarioRepositorio;
            _contratanteRepositorio = contratanteRepositorio;
            _administradorRepositorio = administradorRepositorio;
            _prestadorDeServicoRepositorio = prestadorDeServicoRepositorio;
            _gestorRepositorio = gestorRepositorio;
            _funcionalidadeRepositorio = funcionalidadeRepositorio;
            _acessoRepositorio = acessoRepositorio;
            _beneficiarioRepositorio = beneficiarioRepositorio;
            _enderecoRepositorio = enderecoRepositorio;
            _medicamentoRepositorio = medicamentoRepositorio;
            _estadoRepostorio = estadoRepositorio;
            _cidadeRepositorio = cidadeRepositorio;
            _competenciaRepositorio = competenciaRepositorio;
            _condicaoClinicaRepositorio = condicaoClinicaRepositorio;
            _beneficiarioCondicaoClinicaRepositorio = beneficiarioCondicaoClinicaRepositorio;
            _prestadorDeServicoCompetenciaRepositorio = prestadorDeServicoCompetenciaRepositorio;
            _beneficiarioMedicamentoRepositorio = beneficiarioMedicamentoRepositorio;
            _viaDeUsoMedicamentoRepositorio = viaDeUsoMedicamentoRepositorio;
            _tipoMedicamentoRepositorio = tipoMedicamentoRepositorio;
            _posologiaRepositorio = posologiaRepositorio;
            _solicitacaoContratoRepositorio = solicitacaoContratoRepositorio;
            _contratoRepositorio = contratoRepositorio;
            _tarefaRepositorio = tarefaRepositorio;
            _tarefaRealizadaRepositorio = tarefaRealizadaRepositorio;
            _medicoBeneficiarioRepositorio = medicoBeneficiarioRepositorio;
            _especialidadeMedicaRepositorio = especialidadeMedicaRepositorio;
            _unidadeDeMedidaRepositorio = unidadeDeMedidaRepositorio;
            _tipoContatoRepositorio = tipoContatoRepositorio;
            _contatoRepositorio = contatoRepositorio;
        }
    }
}