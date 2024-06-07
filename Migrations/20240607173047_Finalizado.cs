using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iCompass.Migrations
{
    /// <inheritdoc />
    public partial class Finalizado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DadosInfluencerSeguidores",
                table: "DadosInfluencer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DadosInfluencerSeguidores",
                table: "DadosInfluencer",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
