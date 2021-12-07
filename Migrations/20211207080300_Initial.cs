using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFilmes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ano = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duracao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FaixaEtaria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Ano", "Duracao", "FaixaEtaria", "Genero", "Titulo" },
                values: new object[] { 1, "2069", "2 horas", "+18", "Ação", "A volta dos que não foram" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Ano", "Duracao", "FaixaEtaria", "Genero", "Titulo" },
                values: new object[] { 2, "2069", "2 horas", "+18", "Ação", "As tranças do rei careca" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Ano", "Duracao", "FaixaEtaria", "Genero", "Titulo" },
                values: new object[] { 3, "2069", "2 horas", "+18", "Ação", "Poeira em alto mar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
