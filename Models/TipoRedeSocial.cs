using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCompass.Models
{
    [Table("TipoRedeSocial")]
    public class TipoRedeSocial
    {
        [Column("TipoRedeSocialId")]
        [Display(Name = "Código do Tipo de Rede Social")]
        public int TipoRedeSocialId { get; set; }

        [Column("NomeTipoRedeSocial")]
        [Display(Name = "Nome do Tipo de Rede Social")]
        public string NomeTipoRedeSocial { get; set; } = string.Empty;

    }
}
