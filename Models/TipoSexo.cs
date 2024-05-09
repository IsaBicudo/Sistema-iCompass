using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCompass.Models
{
    [Table("TipoSexo")]
    public class TipoSexo
    {
        [Column("TipoSexoId")]
        [Display(Name = "Código do Tipo de Sexo")]
        public int TipoSexoId { get; set; }

        [Column("NomeTipoSexo")]
        [Display(Name = "Nome do Tipo de Sexo")]
        public string NomeTipoSexo { get; set; } = string.Empty;

    }
}
