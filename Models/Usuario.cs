using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCompass.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código do Usuário")]
        public int UsuarioId { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do Usuário")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("IdadeUsuario")]
        [Display(Name = "Idade do Usuário")]
        public int IdadeUsuario { get; set; }

        [ForeignKey("TipoSexoId")]
        public int TipoSexoId { get; set; }

        public TipoSexo? TipoSexo { get; set; }

        [Column("CpfUsuario")]
        [Display(Name = "Cpf do Usuário")]
        public int CpfUsuario { get; set; }

        [Column("EnderecoUsuario")]
        [Display(Name = "Endereço do Usuário")]
        public string EnderecoUsuario { get; set; } = string.Empty;

        [Column("TelefoneUsuario")]
        [Display(Name = "Telefone do Usuário")]
        public int TelefoneUsuario { get; set; }

        [ForeignKey("TipoUsuarioId")]
        public int TipoUsuarioId { get; set; }

        public TipoUsuario? TipoUsuario { get; set; }

        [ForeignKey("PlanoId")]
        public int PlanoId { get; set; }

        public Plano? Plano { get; set; }

        [Column("EmailUsuario")]
        [Display(Name = "E-mail do Usuário")]
        public string EmailUsuario { get; set; } = string.Empty;

        [Column("SenhaUsuario")]
        [Display(Name = "Senha do Usuário")]
        public string SenhaUsuario { get; set; } = string.Empty;

        [Column("ConfirmarSenhaUsuario")]
        [Display(Name = "Confirmar Senha do Usuário")]
        public string ConfirmarSenhaUsuario { get; set; } = string.Empty;
    }
}
