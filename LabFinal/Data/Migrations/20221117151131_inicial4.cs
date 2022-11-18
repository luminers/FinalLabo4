using Microsoft.EntityFrameworkCore.Migrations;

namespace LabFinal.Data.Migrations
{
    public partial class inicial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoria",
                table: "albums");

            migrationBuilder.AddColumn<int>(
                name: "categoriaId",
                table: "albums",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_albums_categoriaId",
                table: "albums",
                column: "categoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_albums_categorias_categoriaId",
                table: "albums",
                column: "categoriaId",
                principalTable: "categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_albums_categorias_categoriaId",
                table: "albums");

            migrationBuilder.DropIndex(
                name: "IX_albums_categoriaId",
                table: "albums");

            migrationBuilder.DropColumn(
                name: "categoriaId",
                table: "albums");

            migrationBuilder.AddColumn<string>(
                name: "categoria",
                table: "albums",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
