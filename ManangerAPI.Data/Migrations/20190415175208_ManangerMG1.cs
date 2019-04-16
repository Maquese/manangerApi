using Microsoft.EntityFrameworkCore.Migrations;

namespace ManangerApi.Data.Migrations
{
    public partial class ManangerMG1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Medico",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Paciente",
                table: "Usuario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Medico",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Paciente",
                table: "Usuario");
        }
    }
}
