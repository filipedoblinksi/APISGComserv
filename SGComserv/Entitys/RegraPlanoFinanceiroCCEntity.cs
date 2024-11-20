using SGComserv.AbstractClass;
using SGComserv.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGComserv.Entitys;

[Table("tb_regra_planofinanceiro_cc")]
public class RegraPlanoFinanceiroCCEntity : BaseEntity<RegraPlanoFinanceiroCCEntity>
{
    [Key, Display(Name = "ID Plano Financeiro", Description = "", AutoGenerateField = true)]
    public string IdPlanoFinanceiro { get; set; } = string.Empty;

    [Key, Display(Name = "ID Centro Custo", Description = "", AutoGenerateField = true)]
    public string IdCentroCusto { get; set; } = string.Empty;

    [Display(Name = "ID Plano Contabil", Description = "", AutoGenerateField = true)]
    public string IdPlanoContabil { get; set; } = string.Empty;

    [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public PlanoFinanceiroEntity DadosPlanoFinanceiro { get; set; } = new PlanoFinanceiroEntity();
    [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public CentroCustoEntity DadosCentroCusto { get; set; } = new CentroCustoEntity();
    [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public PlanoContabilEntity DadosPlanoContabil { get; set; } = new PlanoContabilEntity();
}
