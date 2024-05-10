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
        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("IdadeUsuario")]
        [Display(Name = "Idade")]
        public int IdadeUsuario { get; set; }

        [ForeignKey("TipoSexoId")]
        public int TipoSexoId { get; set; }
        [Display(Name = "Sexo")]

        public TipoSexo? TipoSexo { get; set; }

        [Column("CpfUsuario")]
        [Display(Name = "Cpf")]
        public int CpfUsuario { get; set; }

        [Column("EnderecoUsuario")]
        [Display(Name = "Endereço")]
        public string EnderecoUsuario { get; set; } = string.Empty;

        [Column("TelefoneUsuario")]
        [Display(Name = "Telefone")]
        public int TelefoneUsuario { get; set; }

        [ForeignKey("TipoUsuarioId")]
        public int TipoUsuarioId { get; set; }
        [Display(Name = "Tipo Usuário")]

        public TipoUsuario? TipoUsuario { get; set; }

        [ForeignKey("PlanoId")]
        public int PlanoId { get; set; }

        public Plano? Plano { get; set; }

        [Column("EmailUsuario")]
        [Display(Name = "E-mail")]
        public string EmailUsuario { get; set; } = string.Empty;

        [Column("SenhaUsuario")]
        [Display(Name = "Senha")]
        public string SenhaUsuario { get; set; } = string.Empty;

        [Column("ConfirmarSenhaUsuario")]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmarSenhaUsuario { get; set; } = string.Empty;
    }
}
