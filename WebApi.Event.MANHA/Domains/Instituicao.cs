using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Event.MANHA.Domains
{
    [Table(nameof(Instituicao))]
    [Index(nameof(CNPJ),IsUnique = true)]
    public class Instituicao
    {
        [Key]
        public Guid IdInstituicao { get; set; } = Guid.NewGuid();

        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage ="CNPJ obrigatorio")]
        [StringLength(14)]
        public String? CNPJ { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="O endereco e obrigatorio")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome fantasia e obrigatorio")]
        public string? NomeFantasia { get; set; }
    }
}
