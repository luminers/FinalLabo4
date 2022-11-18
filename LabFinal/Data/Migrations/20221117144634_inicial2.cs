using Microsoft.EntityFrameworkCore.Migrations;

namespace LabFinal.Data.Migrations
{
    public partial class inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdAlbum",
                table: "integrantes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "albumId",
                table: "integrantes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_integrantes_albumId",
                table: "integrantes",
                column: "albumId");

            migrationBuilder.AddForeignKey(
                name: "FK_integrantes_albums_albumId",
                table: "integrantes",
                column: "albumId",
                principalTable: "albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_integrantes_albums_albumId",
                table: "integrantes");

            migrationBuilder.DropIndex(
                name: "IX_integrantes_albumId",
                table: "integrantes");

            migrationBuilder.DropColumn(
                name: "IdAlbum",
                table: "integrantes");

            migrationBuilder.DropColumn(
                name: "albumId",
                table: "integrantes");
        }
    }
}
