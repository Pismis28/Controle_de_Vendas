using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_de_vendas.Migrations
{
    /// <inheritdoc />
    public partial class update9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acesso",
                table: "Vendedor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Acesso",
                table: "Venda",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acesso",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "Acesso",
                table: "Venda");
        }
    }
}
