using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCompass.Models
{
    [Table("DadosInfluencer")]
    public class DadosInfluencer
    {
        [Column("DadosInfluencerId")]
        [Display(Name = "Código dos Dados do Influencer")]
        public int DadosInfluencerId { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        [Display(Name = "Usuário")]
        public Usuario? Usuario { get; set; }

        [ForeignKey("TipoConteudoId")]       
        public int TipoConteudoId { get; set; }
        [Display(Name = "Conteúdo")]
        public TipoConteudo? TipoConteudo { get; set; }

        [ForeignKey("TipoRedeSocialId")]
        public int TipoRedeSocialId { get; set; }
        [Display(Name = "Rede Social")]
        public TipoRedeSocial? TipoRedeSocial { get; set; }
    }
}
