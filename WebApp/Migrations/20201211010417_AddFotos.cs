using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class AddFotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RutaFoto",
                table: "usuarios1",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "usuarios1",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RutaFoto",
                table: "usuarios1");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "usuarios1");
        }
    }
}
