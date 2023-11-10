using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academia.Migrations
{
    public partial class TreinoBD1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Cliente",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Treino",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Matricula = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Segunda = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Terca = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Quarta = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Quinta = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Sexta = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Sabado = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Domingo = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Altura = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Peso = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    IMC = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataAdicionado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataModificado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treino", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Treino");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Cliente");
        }
    }
}
