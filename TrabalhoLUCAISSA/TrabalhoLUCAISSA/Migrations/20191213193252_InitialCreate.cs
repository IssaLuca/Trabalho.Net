using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabalhoLUCAISSA.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    JogadorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Idade = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Nacionalidade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.JogadorID);
                });

            migrationBuilder.CreateTable(
                name: "Placar",
                columns: table => new
                {
                    PlacarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JogadorID = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Pontuacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placar", x => x.PlacarID);
                    table.ForeignKey(
                        name: "FK_Placar_Jogador_JogadorID",
                        column: x => x.JogadorID,
                        principalTable: "Jogador",
                        principalColumn: "JogadorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Placar_JogadorID",
                table: "Placar",
                column: "JogadorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Placar");

            migrationBuilder.DropTable(
                name: "Jogador");
        }
    }
}
