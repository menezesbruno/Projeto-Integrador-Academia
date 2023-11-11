using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academia.Migrations
{
    public partial class imcup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Meta",
                table: "Treino",
                newName: "IMC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IMC",
                table: "Treino",
                newName: "Meta");
        }
    }
}
