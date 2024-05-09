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

        [ForeignKey("IdUsuario")]
        public int IdUsuario { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("IdTipoConteudo")]       
        public int IdTipoConteudo { get; set; }
        [Display(Name = "Conteúdo")]
        public TipoConteudo? TipoConteudo { get; set; }

        [ForeignKey("IdTipoRedeSocial")]
        public int IdTipoRedeSocial { get; set; }
        [Display(Name = "Rede Social")]
        public TipoRedeSocial? TipoRedeSocial { get; set; }
    }
}
