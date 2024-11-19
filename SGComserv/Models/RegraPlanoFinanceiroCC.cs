using System.ComponentModel.DataAnnotations;

namespace SGComserv.Models;

public class RegraPlanoFinanceiroCC {
    public string? IdPlanoFinanceiro { get; set; }
    public string? IdCentroCusto { get; set; }
    public string? IdPlanoContabil { get; set; }
    public PlanoFinanceiro DadosPlanoFinanceiro { get; set; } = new PlanoFinanceiro();
    public CentroCusto DadosCentroCusto { get; set; } = new CentroCusto();
    public PlanoContabil DadosPlanoContabil { get; set; } = new PlanoContabil();
}
