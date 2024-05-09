using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCompass.Models
{
    [Table("Plano")]
    public class Plano
    {
        [Column("PlanoId")]
        [Display(Name = "Código do Plano")]
        public int PlanoId { get; set; }

        [Column("NomePlano")]
        [Display(Name = "Plano")]
        public string NomePlano { get; set; } = string.Empty;

        [Column("DescricaoPlano")]
        [Display(Name = "Descrição")]
        public string DescricaoPlano { get; set; } = string.Empty;

        [Column("ValorPlano")]
        [Display(Name = "Valor")]
        public double ValorPlano { get; set; } 
    }
}
