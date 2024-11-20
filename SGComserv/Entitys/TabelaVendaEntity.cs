using SGComserv.AbstractClass;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGComserv.Entitys;

[Table("tb_tabelavenda")]
public class TabelaVendaEntity : BaseEntity<TabelaVendaEntity>
{
    [Key, Display(Name = "ID", Description = "", AutoGenerateField = true)]
    public int Id { get; set; }

    [Display(Name = "Descrição", Description = "", AutoGenerateField = true)]
    public string Descricao { get; set; } = string.Empty;
}
