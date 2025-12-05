using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorLivros.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativado",
                table: "Usuarios",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativado",
                table: "Usuarios");
        }
    }
}
