﻿// <auto-generated />
using ManangerAPI.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManangerApi.Data.Migrations
{
    [DbContext(typeof(ContextoDb))]
    [Migration("20190415175208_ManangerMG1")]
    partial class ManangerMG1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Acesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FuncionalidadeId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("FuncionalidadeId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Acesso");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Funcionalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.ToTable("Funcionalidade");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Administrador", b =>
                {
                    b.HasBaseType("ManangerAPI.Data.Entidades.Usuario");


                    b.ToTable("Administrador");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Contratante", b =>
                {
                    b.HasBaseType("ManangerAPI.Data.Entidades.Usuario");

                    b.Property<string>("Medico");

                    b.Property<int>("Paciente");

                    b.ToTable("Contratante");

                    b.HasDiscriminator().HasValue("Contratante");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Acesso", b =>
                {
                    b.HasOne("ManangerAPI.Data.Entidades.Funcionalidade", "FUncionalidade")
                        .WithMany()
                        .HasForeignKey("FuncionalidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ManangerAPI.Data.Entidades.Usuario", "Usuario")
                        .WithMany("Acessos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
