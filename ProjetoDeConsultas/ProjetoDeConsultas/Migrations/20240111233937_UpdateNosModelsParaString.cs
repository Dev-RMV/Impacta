using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoDeConsultas.Migrations
{
    public partial class UpdateNosModelsParaString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Especialidade",
                table: "Medico",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Especialidade",
                table: "Medico");
        }
    }
}
