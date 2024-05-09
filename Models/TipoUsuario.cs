using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCompass.Models
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        [Column("TipoUsuarioId")]
        [Display(Name = "Código do Tipo Usuário")]
        public int TipoUsuarioId { get; set; }

        [Column("NomeTipoUsuario")]
        [Display(Name = "Nome do Tipo de Usuário")]
        public string NomeTipoUsuario { get; set; } = string.Empty;
    }
}
