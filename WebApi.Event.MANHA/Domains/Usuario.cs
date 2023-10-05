using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Event.MANHA.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Nome do usuario obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email do usuario obrigatorio!")]
        public string? Email { get; set; }

        [Column(TypeName ="CHAR(60)")]
        [Required(ErrorMessage ="Senha Obrigatoria!")]
        [StringLength(60, MinimumLength =6, ErrorMessage ="Senha deve conter de 6 a 60 caracteres!")]
        
        public string? Senha { get; set; }

        [Required(ErrorMessage ="Informe o tipo de usuario!")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        //[ForeignKey("IdTipoUsuario")]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}