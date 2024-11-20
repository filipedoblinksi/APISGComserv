using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SGComserv.AbstractClass;
using SGComserv.Attributes;

namespace SGComserv.Entitys;

[Table("tb_subtabelavenda")]
public class SubTabelaVendaEntity : BaseEntity<SubTabelaVendaEntity>
{
    [IgnoreOnInsert]
    [AutoIncrement]
    [Key, Required, Display(Name = "ID", Description = "", AutoGenerateField = true)]
    public int Id { get; set; }

    [Display(Name = "ID Tabela Venda", Description = "", AutoGenerateField = true)]
    public int IdTabelaVenda { get; set; }

    [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    [Display(Name = "Tabela Venda", Description = "", AutoGenerateField = true)]
    public string DescricaoTabelaVenda { get; set; } = string.Empty;

    [Display(Name = "Descrição", Description = "", AutoGenerateField = true)]
    public string Descricao { get; set; } = string.Empty;

    [Display(Name = "Detalhes", Description = "", AutoGenerateField = true)]
    public string Detalhes { get; set; } = string.Empty;

    [Display(Name = "Data Inicial", Description = "", AutoGenerateField = true)]
    public DateTime? DataInicial { get; set; }

    [Display(Name = "Data Final", Description = "", AutoGenerateField = true)]
    public DateTime? DataFinal { get; set; }

    [Display(Name = "Ativa", Description = "", AutoGenerateField = true)]
    public bool Ativo { get; set; }

    [Display(Name = "Padrão", Description = "", AutoGenerateField = true)]
    public bool Padrao { get; set; }

    public override bool Equals(object? obj)
    {
        var item = obj as SubTabelaVendaEntity;
        if (item == null) return false;

        return Id.Equals(item.Id);
    }

    public override string ToString()
        => $"{DescricaoTabelaVenda} | {Descricao}";

    public override int GetHashCode()
        => Id.GetHashCode();
}
