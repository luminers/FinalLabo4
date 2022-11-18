using Microsoft.EntityFrameworkCore.Migrations;

namespace LabFinal.Data.Migrations
{
    public partial class inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoria",
                table: "categorias");

            migrationBuilder.AddColumn<string>(
                name: "nombreCategoria",
                table: "categorias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nombreCategoria",
                table: "categorias");

            migrationBuilder.AddColumn<string>(
                name: "categoria",
                table: "categorias",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
