using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_de_vendas.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acesso",
                table: "Administrador",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Produto",
                table: "Administrador",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Administrador",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Administrador",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acesso",
                table: "Administrador");

            migrationBuilder.DropColumn(
                name: "Produto",
                table: "Administrador");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Administrador");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Administrador");
        }
    }
}
