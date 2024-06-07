using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iCompass.Migrations
{
    /// <inheritdoc />
    public partial class Alteracao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DadosInfluencerSeguidores",
                table: "DadosInfluencer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DadosInfluencerSeguidores",
                table: "DadosInfluencer");
        }
    }
}
