using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManangerApi.Data.Migrations
{
    public partial class MigrationMG3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paciente",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Medico",
                table: "Usuario",
                newName: "Telefone");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comentario",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Termos",
                table: "Usuario",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Comentario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Termos",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Usuario",
                newName: "Medico");

            migrationBuilder.AddColumn<int>(
                name: "Paciente",
                table: "Usuario",
                nullable: true);
        }
    }
}
