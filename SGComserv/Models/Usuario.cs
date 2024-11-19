namespace SGComserv.Models;

public class Usuario {
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int IdFornecedor { get; set; }
    public bool Inativo { get; set; }
    public bool AcessoRemoto { get; set; }
    public string? IpPublico { get; set; }
    public List<NivelSenha> NiveisSenha { get; set; } = new List<NivelSenha>();
    public decimal PercentualDescontoVenda { get; set; }
}
