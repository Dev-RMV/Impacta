using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoDeConsultas.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Cliente_ClienteId",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Medico_MedicoId",
                table: "Consulta");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_ClienteId",
                table: "Consulta");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_MedicoId",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "MedicoId",
                table: "Consulta");

            migrationBuilder.AddColumn<string>(
                name: "Cliente",
                table: "Consulta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Medico",
                table: "Consulta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "Medico",
                table: "Consulta");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedicoId",
                table: "Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_ClienteId",
                table: "Consulta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_MedicoId",
                table: "Consulta",
                column: "MedicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Cliente_ClienteId",
                table: "Consulta",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Medico_MedicoId",
                table: "Consulta",
                column: "MedicoId",
                principalTable: "Medico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
