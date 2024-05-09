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

        public Usuario? Usuario { get; set; }

        [ForeignKey("TipoRedeSocialId")]
        public int TipoRedeSocialId { get; set; }

        public TipoRedeSocial? TipoRedeSocial { get; set; }

        [ForeignKey("TipoConteudoId")]
        public int TipoConteudoId { get; set; }

        public TipoConteudo? TipoConteudo { get; set; }

        [Column("LikePostagem")]
        [Display(Name = "Like da Postagem")]
        public int LikePostagem { get; set; }

        [Column("DeslikePostagem")]
        [Display(Name = "Deslike da Postagem")]
        public int DeslikePostagem { get; set; }

        [Column("CompartilhamentoPostagem")]
        [Display(Name = "Compartilhamento da Postagem")]
        public int CompartilhamentoPostagem { get; set; }

        [Column("SalvosPostagem")]
        [Display(Name = "Salvos da Postagem")]
        public int SalvosPostagem { get; set; }

        [Column("QuantidadeComentariosPostagem")]
        [Display(Name = "Quantidades de Comentários da Postagem")]
        public int QuantidadeComentariosPostagem { get; set; }
    }
}
