using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SGComserv.AbstractClass;
using SGComserv.Attributes;
using SGComserv.Enums;

namespace SGComserv.Entitys;

[Table("tb_centrocusto")]
public class CentroCustoEntity : BaseEntity<CentroCustoEntity>
{
    public CentroCustoEntity()
    {
        id = "";
        idOriginal = "";
        descricao = string.Empty;
        idNaturezaConta = ENaturezaConta.Sintetica;
    }

    [Key, Display(Name = "ID", Description = "", AutoGenerateField = true)]
    [KeyOriginal(nameof(idOriginal))]
    public string id { get; set; }

    [Display(Name = "ID Original", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public string idOriginal { get; set; }

    [Display(Name = "Descrição", Description = "", AutoGenerateField = true)]
    [MaxLength(80)]
    public string descricao { get; set; }

    [Display(Name = "Natureza", Description = "", AutoGenerateField = true)]
    public ENaturezaConta idNaturezaConta { get; set; }
}
