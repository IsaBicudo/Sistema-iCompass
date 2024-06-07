using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iCompass.Migrations
{
    /// <inheritdoc />
    public partial class Alteracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BiografiaUsuario",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FotoUsuario",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BiografiaUsuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "FotoUsuario",
                table: "Usuario");
        }
    }
}
