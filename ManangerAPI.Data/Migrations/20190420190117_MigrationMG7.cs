using Microsoft.EntityFrameworkCore.Migrations;

namespace ManangerApi.Data.Migrations
{
    public partial class MigrationMG7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CursosCertificacoes",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HistoricoProfissional",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Competencias",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Funcionalidade",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Endereco",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Acesso",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CursosCertificacoes",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "HistoricoProfissional",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Competencias",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Funcionalidade");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Acesso");
        }
    }
}
