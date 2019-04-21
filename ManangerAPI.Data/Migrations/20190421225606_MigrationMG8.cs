using Microsoft.EntityFrameworkCore.Migrations;

namespace ManangerApi.Data.Migrations
{
    public partial class MigrationMG8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Analisado",
                table: "Usuario",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Aprovado",
                table: "Usuario",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Analisado",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Aprovado",
                table: "Usuario");
        }
    }
}
