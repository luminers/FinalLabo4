using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LabFinal.Data.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "albums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    resumen = table.Column<string>(nullable: true),
                    fechaCreacion = table.Column<DateTime>(nullable: false),
                    imagenTapa = table.Column<string>(nullable: true),
                    categoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "integrantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    biografia = table.Column<string>(nullable: true),
                    foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_integrantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "integrantesAlbums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAlbum = table.Column<int>(nullable: false),
                    IdIntegrante = table.Column<int>(nullable: false),
                    albumId = table.Column<int>(nullable: true),
                    integranteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_integrantesAlbums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_integrantesAlbums_albums_albumId",
                        column: x => x.albumId,
                        principalTable: "albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_integrantesAlbums_integrantes_integranteId",
                        column: x => x.integranteId,
                        principalTable: "integrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_integrantesAlbums_albumId",
                table: "integrantesAlbums",
                column: "albumId");

            migrationBuilder.CreateIndex(
                name: "IX_integrantesAlbums_integranteId",
                table: "integrantesAlbums",
                column: "integranteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "integrantesAlbums");

            migrationBuilder.DropTable(
                name: "albums");

            migrationBuilder.DropTable(
                name: "integrantes");
        }
    }
}
