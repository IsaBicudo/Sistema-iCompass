using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCompass.Models
{
    [Table("TipoConteudo")]
    public class TipoConteudo
    {
        [Column("TipoConteudoId")]
        [Display(Name = "Código do Tipo do Conteúdo")]
        public int TipoConteudoId { get; set; }

        [Column("NomeTipoConteudo")]
        [Display(Name = "Nome do Tipo do Conteúdo")]
        public string NomeTipoConteudo { get; set; } = string.Empty;

        [Column("PublicoAlvo")]
        [Display(Name = "Público Alvo ")]
        public string PublicoAlvo { get; set; } = string.Empty;

    }
}
