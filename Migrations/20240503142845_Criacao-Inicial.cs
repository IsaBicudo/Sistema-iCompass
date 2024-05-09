using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iCompass.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    PlanoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePlano = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoPlano = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorPlano = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.PlanoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoConteudo",
                columns: table => new
                {
                    TipoConteudoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoConteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicoAlvo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoConteudo", x => x.TipoConteudoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoRedeSocial",
                columns: table => new
                {
                    TipoRedeSocialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoRedeSocial = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRedeSocial", x => x.TipoRedeSocialId);
                });

            migrationBuilder.CreateTable(
                name: "TipoSexo",
                columns: table => new
                {
                    TipoSexoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoSexo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSexo", x => x.TipoSexoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    TipoUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.TipoUsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdadeUsuario = table.Column<int>(type: "int", nullable: false),
                    TipoSexoId = table.Column<int>(type: "int", nullable: false),
                    CpfUsuario = table.Column<int>(type: "int", nullable: false),
                    EnderecoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefoneUsuario = table.Column<int>(type: "int", nullable: false),
                    TipoUsuarioId = table.Column<int>(type: "int", nullable: false),
                    PlanoId = table.Column<int>(type: "int", nullable: false),
                    EmailUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenhaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmarSenhaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Plano_PlanoId",
                        column: x => x.PlanoId,
                        principalTable: "Plano",
                        principalColumn: "PlanoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_TipoSexo_TipoSexoId",
                        column: x => x.TipoSexoId,
                        principalTable: "TipoSexo",
                        principalColumn: "TipoSexoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_TipoUsuario_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TipoUsuario",
                        principalColumn: "TipoUsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DadosInfluencer",
                columns: table => new
                {
                    DadosInfluencerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    IdTipoConteudo = table.Column<int>(type: "int", nullable: false),
                    TipoConteudoId = table.Column<int>(type: "int", nullable: true),
                    IdTipoRedeSocial = table.Column<int>(type: "int", nullable: false),
                    TipoRedeSocialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosInfluencer", x => x.DadosInfluencerId);
                    table.ForeignKey(
                        name: "FK_DadosInfluencer_TipoConteudo_TipoConteudoId",
                        column: x => x.TipoConteudoId,
                        principalTable: "TipoConteudo",
                        principalColumn: "TipoConteudoId");
                    table.ForeignKey(
                        name: "FK_DadosInfluencer_TipoRedeSocial_TipoRedeSocialId",
                        column: x => x.TipoRedeSocialId,
                        principalTable: "TipoRedeSocial",
                        principalColumn: "TipoRedeSocialId");
                    table.ForeignKey(
                        name: "FK_DadosInfluencer_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Postagem",
                columns: table => new
                {
                    PostagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    TipoRedeSocialId = table.Column<int>(type: "int", nullable: false),
                    TipoConteudoId = table.Column<int>(type: "int", nullable: false),
                    LikePostagem = table.Column<int>(type: "int", nullable: false),
                    DeslikePostagem = table.Column<int>(type: "int", nullable: false),
                    CompartilhamentoPostagem = table.Column<int>(type: "int", nullable: false),
                    SalvosPostagem = table.Column<int>(type: "int", nullable: false),
                    QuantidadeComentariosPostagem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postagem", x => x.PostagemId);
                    table.ForeignKey(
                        name: "FK_Postagem_TipoConteudo_TipoConteudoId",
                        column: x => x.TipoConteudoId,
                        principalTable: "TipoConteudo",
                        principalColumn: "TipoConteudoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postagem_TipoRedeSocial_TipoRedeSocialId",
                        column: x => x.TipoRedeSocialId,
                        principalTable: "TipoRedeSocial",
                        principalColumn: "TipoRedeSocialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postagem_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DadosInfluencer_TipoConteudoId",
                table: "DadosInfluencer",
                column: "TipoConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_DadosInfluencer_TipoRedeSocialId",
                table: "DadosInfluencer",
                column: "TipoRedeSocialId");

            migrationBuilder.CreateIndex(
                name: "IX_DadosInfluencer_UsuarioId",
                table: "DadosInfluencer",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Postagem_TipoConteudoId",
                table: "Postagem",
                column: "TipoConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_Postagem_TipoRedeSocialId",
                table: "Postagem",
                column: "TipoRedeSocialId");

            migrationBuilder.CreateIndex(
                name: "IX_Postagem_UsuarioId",
                table: "Postagem",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PlanoId",
                table: "Usuario",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_TipoSexoId",
                table: "Usuario",
                column: "TipoSexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_TipoUsuarioId",
                table: "Usuario",
                column: "TipoUsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosInfluencer");

            migrationBuilder.DropTable(
                name: "Postagem");

            migrationBuilder.DropTable(
                name: "TipoConteudo");

            migrationBuilder.DropTable(
                name: "TipoRedeSocial");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Plano");

            migrationBuilder.DropTable(
                name: "TipoSexo");

            migrationBuilder.DropTable(
                name: "TipoUsuario");
        }
    }
}
