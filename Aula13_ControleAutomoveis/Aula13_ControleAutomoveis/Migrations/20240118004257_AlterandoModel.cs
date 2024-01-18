using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula13_ControleAutomoveis.Migrations
{
    public partial class AlterandoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Proprietario_ProprietarioId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_ProprietarioId",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "ProprietarioId",
                table: "Veiculo");

            migrationBuilder.AddColumn<string>(
                name: "Proprietario",
                table: "Veiculo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Veiculos",
                table: "Proprietario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proprietario",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "Veiculos",
                table: "Proprietario");

            migrationBuilder.AddColumn<int>(
                name: "ProprietarioId",
                table: "Veiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_ProprietarioId",
                table: "Veiculo",
                column: "ProprietarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Proprietario_ProprietarioId",
                table: "Veiculo",
                column: "ProprietarioId",
                principalTable: "Proprietario",
                principalColumn: "ProprietarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
