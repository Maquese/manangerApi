

using ManangerAPI.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ManangerAPI.Data.Contexto
{
    public class ContextoDb : DbContext
    {
        public DbSet<Acesso> Acesso { get; set; }
        public DbSet<Funcionalidade> Funcionalidade { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public ContextoDb() 
        {
            
        }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-93KENU91\SQLEXPRESS;Database=Mananger;User Id=kenney;password=kenney123;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}