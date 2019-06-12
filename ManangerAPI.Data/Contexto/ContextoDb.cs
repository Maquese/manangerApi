

using System;
using System.Diagnostics;
using ManangerAPI.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ManangerAPI.Data.Contexto
{
    public class ContextoDb : DbContext
    {
        public DbSet<Acesso> Acesso { get; set; }        
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Beneficiario> Beneficiario { get; set; }
        public DbSet<Contratante> Contratante { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Funcionalidade> Funcionalidade { get; set; }
        public DbSet<Gestor> Gestor { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<PrestadorDeServico> PrestadorDeServico { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<StatusEntidade> StatusEntidade { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Medicamento> Medicamento { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<CondicaoClinica> CondicaoClinica { get; set; }
        public DbSet<Competencia> Competencia { get; set; }
        public DbSet<BeneficiarioCondicaoClinica> BeneficiarioCondicaoClinica { get; set; }
        public DbSet<PrestadorDeServicoCompetencia> PrestadorDeServicoCompetencia { get; set; }
        public DbSet<BeneficiarioMedicamento> BeneficiarioMedicamento { get; set; }
        public DbSet<TipoMedicamento> TipoMedicamento { get; set; }
        public DbSet<ViaDeUsoMedicamento> ViaDeUsoMedicamento { get; set; }
        public DbSet<Posologia> Posologia { get; set; }
        public ContextoDb(DbContextOptions options) : base(options)
        {
            
        }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<PrestadorDeServico>().ToTable("PrestadorDeServico");
            modelBuilder.Entity<Contratante>().ToTable("Contratante");
            modelBuilder.Entity<Administrador>().ToTable("Administrador");
            //base.OnModelCreating(modelBuilder);
        }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            //optionsBuilder.
            //optionsBuilder.UseSqlServer(@"Server=LAPTOP-93KENU91\SQLEXPRESS;Database=Mananger;User Id=kenney;password=kenney123;"); //casa
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-TKPA4BQ\SQLEXPRESS;Database=Mananger;Trusted_Connection=True;"); //trabalho
            //optionsBuilder.UseSqlServer(@"Server=GIULIANO\SQLEXPRESS;Database=Mananger;Trusted_Connection=True;"); //trabalho
             //optionsBuilder.UseSqlServer(@"Server=LAPTOP-N20JNSB4\SQLEXPRESS;Database=Mananger;Trusted_Connection=True;"); //giu
            //base.OnConfiguring(optionsBuilder);
        }
    }
}