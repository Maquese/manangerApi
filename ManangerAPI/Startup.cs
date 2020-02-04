using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManangerAPI.Application.Contratos;
using ManangerAPI.Data.Contexto;
using ManangerAPI.Data.Contratos;
using ManangerAPI.Data.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ManangerApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        
public static string ConnectionString {  
    get;  
    private set;  
}
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            ConnectionString =  Configuration.GetValue("ConnectionString","").ToString();
            services.AddDbContext<ContextoDb>(x => x.UseNpgsql(ConnectionString));
        
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IApplication,ManangerAPI.Application.ApplicationApp.Application>();            
            services.AddScoped<IUsuarioApplication,ManangerAPI.Application.ApplicationApp.Application>();            
            services.AddScoped<IContratanteApplication,ManangerAPI.Application.ApplicationApp.Application>();            
            services.AddScoped<IAdministradorApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddScoped<IPrestadorDeServicoApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddScoped<IGestorApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddScoped<IBeneficiarioApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddScoped<IMailApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddScoped<IMedicamentoApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddScoped<IDropDownApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddScoped<IDownloadApplication,ManangerAPI.Application.ApplicationApp.Application>();            
            services.AddScoped<ICepApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddScoped<IContratoApplication,ManangerAPI.Application.ApplicationApp.Application>();            
            services.AddScoped<ITarefaApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddScoped<IContatoApplication,ManangerAPI.Application.ApplicationApp.Application>();

            services.AddScoped<IBeneficiarioRepositorio,BeneficiarioRepositorio>();
            services.AddScoped<IAcessoRepositorio,AcessoRepositorio>();
            services.AddScoped<IFuncionalidadeRepositorio,FuncionalidadeRepositorio>();
            services.AddScoped<IUsuarioRepositorio,UsuarioRepositorio>();            
            services.AddScoped<IAdministradorRepositorio,AdministradorRepositorio>();
            services.AddScoped<IContratanteRepositorio,ContratanteRepositorio>();
            services.AddScoped<IGestorRepositorio,GestorRepositorio>();
            services.AddScoped<IPrestadorDeServicoRepositorio,PrestadorDeServicoRepositorio>();            
            services.AddScoped<IEnderecoRepositorio,EnderecoRepositorio>();                        
            services.AddScoped<IMedicamentoRepositorio,MedicamentoRepositorio>();
            services.AddScoped<IEstadoRepositorio,EstadoRepositorio>();
            services.AddScoped<ICidadeRepositorio,CidadeRepositorio>();
            services.AddScoped<ICondicaoClinicaRepositorio,CondicaoClinicaRepositorio>();
            services.AddScoped<ICompetenciaRepositorio,CompetenciaRepositorio>();
            services.AddScoped<IBeneficiarioCondicaoClinicaRepositorio,BeneficiarioCondicaoClinicaRepositorio>();
            services.AddScoped<IPrestadorDeServicoCompetenciaRepositorio,PrestadorDeServicoCompetenciaRepositorio>();
            services.AddScoped<IBeneficiarioMedicamentoRepositorio,BeneficiarioMedicamentoRepositorio>();
            services.AddScoped<IViaDeUsoMedicamentoRepositorio,ViaDeUsoMedicamentoRepositorio>();
            services.AddScoped<ITipoMedicamentoRepositorio,TipoMedicamentoRepositorio>();
            services.AddScoped<IPosologiaRepositorio,PosologiaRepositorio>();
            services.AddScoped<ISolicitacaoContratoRepositorio,SolicitacaoContratoRepositorio>();            
            services.AddScoped<IContratoRepositorio,ContratoRepositorio>();            
            services.AddScoped<IMedicoBeneficiarioRepositorio,MedicoBeneficiarioRepositorio>();            
            services.AddScoped<ITarefaRepositorio,TarefaRepositorio>();
            services.AddScoped<ITarefaRealizadaRepositorio,TarefaRealizadaRepositorio>();
            services.AddScoped<IEspecialidadeMedicaRepositorio,EspecialidadeMedicaRepositorio>();
            services.AddScoped<IUnidadeDeMedidaRepositorio,UnidadeDeMedidaRepositorio>();
            services.AddScoped<IContatoRepositorio,ContatoRepositorio>();
            services.AddScoped<ITipoContatoRepositorio,TipoContatoRepositorio>();
            
        }  

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
             if (env.IsDevelopment())
             {
                 app.UseDeveloperExceptionPage();
             }
             else
            {
               app.UseHsts();
             }
            
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
