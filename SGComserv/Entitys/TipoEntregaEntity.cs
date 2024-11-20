using SGComserv.AbstractClass;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGComserv.Entitys;

[Table("tb_tipoentrega")]
public class TipoEntregaEntity : BaseEntity<TipoEntregaEntity>
{
    public TipoEntregaEntity()
    {
        Id = -1;
        Descricao = "";
        RegraSetorEntrega = 0;
    }

    [Key, Display(Name = "Id", Description = "", AutoGenerateField = true)]
    public int Id { get; set; }

    [Display(Name = "Descricao", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string Descricao { get; set; }

    [Display(Name = "Regra Setor Entrega", Description = "", AutoGenerateField = true)]
    public int RegraSetorEntrega { get; set; }

    //[Display(Name = "backcolor", Description = "", AutoGenerateField = true)]
    //public System.Drawing.Color backcolor { get; set; }
}
