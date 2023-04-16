using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academia.Migrations
{
    public partial class AddClienteFormaPagamentoPersonal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormaPagameto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataAdicionado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataModificado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagameto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataAdicionado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataModificado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    PersonalId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FormaPagamentoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataAdicionado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataModificado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_FormaPagameto_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormaPagameto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_FormaPagamentoId",
                table: "Cliente",
                column: "FormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PersonalId",
                table: "Cliente",
                column: "PersonalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "FormaPagameto");

            migrationBuilder.DropTable(
                name: "Personal");
        }
    }
}
