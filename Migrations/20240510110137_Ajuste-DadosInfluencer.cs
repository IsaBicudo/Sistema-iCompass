using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iCompass.Migrations
{
    /// <inheritdoc />
    public partial class AjusteDadosInfluencer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DadosInfluencer_TipoConteudo_TipoConteudoId",
                table: "DadosInfluencer");

            migrationBuilder.DropForeignKey(
                name: "FK_DadosInfluencer_TipoRedeSocial_TipoRedeSocialId",
                table: "DadosInfluencer");

            migrationBuilder.DropForeignKey(
                name: "FK_DadosInfluencer_Usuario_UsuarioId",
                table: "DadosInfluencer");

            migrationBuilder.DropColumn(
                name: "IdTipoConteudo",
                table: "DadosInfluencer");

            migrationBuilder.DropColumn(
                name: "IdTipoRedeSocial",
                table: "DadosInfluencer");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "DadosInfluencer");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "DadosInfluencer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoRedeSocialId",
                table: "DadosInfluencer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoConteudoId",
                table: "DadosInfluencer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DadosInfluencer_TipoConteudo_TipoConteudoId",
                table: "DadosInfluencer",
                column: "TipoConteudoId",
                principalTable: "TipoConteudo",
                principalColumn: "TipoConteudoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DadosInfluencer_TipoRedeSocial_TipoRedeSocialId",
                table: "DadosInfluencer",
                column: "TipoRedeSocialId",
                principalTable: "TipoRedeSocial",
                principalColumn: "TipoRedeSocialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DadosInfluencer_Usuario_UsuarioId",
                table: "DadosInfluencer",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DadosInfluencer_TipoConteudo_TipoConteudoId",
                table: "DadosInfluencer");

            migrationBuilder.DropForeignKey(
                name: "FK_DadosInfluencer_TipoRedeSocial_TipoRedeSocialId",
                table: "DadosInfluencer");

            migrationBuilder.DropForeignKey(
                name: "FK_DadosInfluencer_Usuario_UsuarioId",
                table: "DadosInfluencer");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "DadosInfluencer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TipoRedeSocialId",
                table: "DadosInfluencer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TipoConteudoId",
                table: "DadosInfluencer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoConteudo",
                table: "DadosInfluencer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoRedeSocial",
                table: "DadosInfluencer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "DadosInfluencer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DadosInfluencer_TipoConteudo_TipoConteudoId",
                table: "DadosInfluencer",
                column: "TipoConteudoId",
                principalTable: "TipoConteudo",
                principalColumn: "TipoConteudoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DadosInfluencer_TipoRedeSocial_TipoRedeSocialId",
                table: "DadosInfluencer",
                column: "TipoRedeSocialId",
                principalTable: "TipoRedeSocial",
                principalColumn: "TipoRedeSocialId");

            migrationBuilder.AddForeignKey(
                name: "FK_DadosInfluencer_Usuario_UsuarioId",
                table: "DadosInfluencer",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId");
        }
    }
}
