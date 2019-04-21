﻿// <auto-generated />
using System;
using ManangerAPI.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManangerApi.Data.Migrations
{
    [DbContext(typeof(ContextoDb))]
    partial class ContextoDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("FuncionalidadeId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Acesso");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Estado");

                    b.Property<string>("Numero");

                    b.Property<string>("Rua");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Funcionalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<string>("Path");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Funcionalidade");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Analisado");

                    b.Property<bool>("Aprovado");

                    b.Property<string>("Comentario");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<int>("Sexo");

                    b.Property<int>("Status");

                    b.Property<string>("Telefone");

                    b.Property<bool>("Termos");

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


                    b.ToTable("Contratante");

                    b.HasDiscriminator().HasValue("Contratante");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Gestor", b =>
                {
                    b.HasBaseType("ManangerAPI.Data.Entidades.Usuario");

                    b.Property<string>("CursosCertificacoes");

                    b.Property<string>("HistoricoProfissional");

                    b.ToTable("Gestor");

                    b.HasDiscriminator().HasValue("Gestor");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.PrestadorDeServico", b =>
                {
                    b.HasBaseType("ManangerAPI.Data.Entidades.Usuario");

                    b.Property<string>("Competencias");

                    b.ToTable("PrestadorDeServico");

                    b.HasDiscriminator().HasValue("PrestadorDeServico");
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Acesso", b =>
                {
                    b.HasOne("ManangerAPI.Data.Entidades.Funcionalidade", "Funcionalidade")
                        .WithMany()
                        .HasForeignKey("FuncionalidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ManangerAPI.Data.Entidades.Usuario", "Usuario")
                        .WithMany("Acessos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManangerAPI.Data.Entidades.Endereco", b =>
                {
                    b.HasOne("ManangerAPI.Data.Entidades.Usuario", "Usuario")
                        .WithOne("Endereco")
                        .HasForeignKey("ManangerAPI.Data.Entidades.Endereco", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
