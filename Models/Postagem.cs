using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCompass.Models
{
    [Table("Postagem")]
    public class Postagem
    {
        [Column("PostagemId")]
        [Display(Name = "Código da Postagem")]
        public int PostagemId { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        [Display(Name = "Usuário")]

        public Usuario? Usuario { get; set; }

        [ForeignKey("TipoRedeSocialId")]
        public int TipoRedeSocialId { get; set; }
        [Display(Name = "Rede Social")]

        public TipoRedeSocial? TipoRedeSocial { get; set; }

        [ForeignKey("TipoConteudoId")]
        public int TipoConteudoId { get; set; }
        [Display(Name = "Conteúdo")]

        public TipoConteudo? TipoConteudo { get; set; }

        [Column("LikePostagem")]
        [Display(Name = "Likes")]
        public int LikePostagem { get; set; }

        [Column("DeslikePostagem")]
        [Display(Name = "Deslikes")]
        public int DeslikePostagem { get; set; }

        [Column("CompartilhamentoPostagem")]
        [Display(Name = "Compartilhamentos")]
        public int CompartilhamentoPostagem { get; set; }

        [Column("SalvosPostagem")]
        [Display(Name = "Salvos")]
        public int SalvosPostagem { get; set; }

        [Column("QuantidadeComentariosPostagem")]
        [Display(Name = "Comentários")]
        public int QuantidadeComentariosPostagem { get; set; }
    }
}
