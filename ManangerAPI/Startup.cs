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

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IApplication,ManangerAPI.Application.ApplicationApp.Application>();            
            services.AddSingleton<IUsuarioApplication,ManangerAPI.Application.ApplicationApp.Application>();            
            services.AddSingleton<IContratanteApplication,ManangerAPI.Application.ApplicationApp.Application>();            
            services.AddSingleton<IAdministradorApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddSingleton<IPrestadorDeServicoApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddSingleton<IGestorApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddSingleton<IBeneficiarioApplication,ManangerAPI.Application.ApplicationApp.Application>();
            services.AddSingleton<IMailApplication,ManangerAPI.Application.ApplicationApp.Application>();

            services.AddSingleton<IBeneficiarioRepositorio,BeneficiarioRepositorio>();
            services.AddSingleton<IAcessoRepositorio,AcessoRepositorio>();
            services.AddSingleton<IFuncionalidadeRepositorio,FuncionalidadeRepositorio>();
            services.AddSingleton<IUsuarioRepositorio,UsuarioRepositorio>();            
            services.AddSingleton<IAdministradorRepositorio,AdministradorRepositorio>();
            services.AddSingleton<IContratanteRepositorio,ContratanteRepositorio>();
            services.AddSingleton<IGestorRepositorio,GestorRepositorio>();
            services.AddSingleton<IPrestadorDeServicoRepositorio,PrestadorDeServicoRepositorio>();
            //services.AddDbContext<ContextoDb>(x => x.UseSqlServer(@"Server=LAPTOP-93KENU91\SQLEXPRESS;Database=Mananger;User Id=kenney;password=kenney123;"));
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
