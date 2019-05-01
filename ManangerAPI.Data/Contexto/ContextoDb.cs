

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
                

        public ContextoDb() 
        {
            
        }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            
            //optionsBuilder.UseSqlServer(@"Server=LAPTOP-93KENU91\SQLEXPRESS;Database=Mananger;User Id=kenney;password=kenney123;"); //casa
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TKPA4BQ\SQLEXPRESS;Database=Mananger;Trusted_Connection=True;"); //trabalho
            base.OnConfiguring(optionsBuilder);
        }
    }
}