using SGComserv.Enums;

namespace SGComserv.Models;

public class PlanoFinanceiro {
    public string? IdPlanoFinanceiro { get; set; }
    public string? IdPlanoFinanceiroOriginal { get; set; }
    public string? Descricao { get; set; }
    public bool desabilitado { get; set; }
    public int? idTipoDocumento { get; set; }
    public TipoDocumentoFinanceiro? DadoTipoDocumentoFinanceiro { get; set; }
    public int? idTipoGasto { get; set; }
    public TipoGasto? DadoTipoGasto { get; set; }
    public bool imposto { get; set; }
    public string? idPlanoContabil { get; set; }
    public PlanoContabil? DadosPlanoContabil { get; set; }
    public string? empresaPermitida { get; set; }
    public ENaturezaConta idNaturezaConta { get; set; }
    public bool obrigatorioCentroCusto { get; set; }
    public bool obrigatorioClasseDeValor { get; set; }
    public ICollection<RegraPlanoFinanceiroCC>? DadosRegraPlanoFinanceiroCC { get; set; }
}
