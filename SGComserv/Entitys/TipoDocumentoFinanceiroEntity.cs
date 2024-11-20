using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SGComserv.AbstractClass;

namespace SGComserv.Entitys;

[Table("tb_ctipopagamento")]
public class TipoDocumentoFinanceiroEntity : BaseEntity<TipoDocumentoFinanceiroEntity>
{

    [Key, Display(Name = "ID", Description = "", AutoGenerateField = true)]
    public int Id { get; set; }

    [Display(Name = "Descricao", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string Descricao { get; set; } = string.Empty;
}
