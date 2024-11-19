using SGComserv.Enums;

namespace SGComserv.Models;

public class Pedido {
    public int Id { get; set; }
    public DateTime? DataCriacao { get; set; }
    public int? IdCriador { get; set; }
    public virtual Usuario UsuarioCriacao { get; set; } = new Usuario();
    public int IdCliente { get; set; }
    public virtual Cliente DadosCliente { get; set; } = new Cliente();
    public string? Observacoes { get; set; }
    public DateTime? DataEntrega { get; set; }
    public int? IdTipoEntrega { get; set; }
    public virtual TipoEntrega DadosTipoEntrega { get; set; } = new TipoEntrega();
    public ETipoPedido IdTipoPedido { get; set; }
    public EFormaPagamento? IdFormaPagamento { get; set; }
    public DateTime? DataFechamento { get; set; }
    public int? IdUsuarioFechamento { get; set; }
    public int? NroNFE { get; set; }
    public bool PedidoAberto { get; set; }
    public int? UsuarioAberto { get; set; }
    public DateTime? dataAbertura { get; set; }
    public bool? excluido { get; set; }
    public int? idUsuarioExcluido { get; set; }
    public DateTime? dataExcluido { get; set; }
    public ETipoVenda IdTipoVenda { get; set; }
    public int? tpFornNFe { get; set; }
    public int? idTranspNFe { get; set; }
    public Fornecedor DadosTranspNFe { get; set; } = new Fornecedor();
    public int? pagamentoFrete { get; set; }
    public string? descricaoPagamentoFrete {
        get {
            string descricao = string.Empty;

            switch (pagamentoFrete) {
                case 0:
                    descricao = "CONTRATADO EMIT.";
                    break;
                case 1:
                    descricao = "CONTRATADO DEST.";
                    break;
                case 2:
                    descricao = "TERCEIROS";
                    break;
                case 3:
                    descricao = "PRÓPRIO EMITENTE";
                    break;
                case 4:
                    descricao = "PRÓPRIO DESTINATÁRIO";
                    break;
                case 9:
                    descricao = "SEM FRETE";
                    break;
                default:
                    break;
            }

            return descricao;
        }
    }
    public string? transp_uf { get; set; }
    public string? transp_placa { get; set; }
    public string? transp_rntc { get; set; }
    public int? nnfe_venda { get; set; }
    public int? envnfe_venda { get; set; }
    public decimal? valorDifal { get; set; }
    public string? ent_cnpj { get; set; }
    public string? ent_nomeRua { get; set; }
    public string? ent_numero { get; set; }
    public string? ent_cep { get; set; }
    public string? ent_complemento { get; set; }
    public string? ent_bairro { get; set; }
    public string? ent_cidade { get; set; }
    public string? ent_estado { get; set; }
    public string? ent_logradouro { get; set; }
    public int idEmpresa { get; set; }
    public virtual Empresa DadosEmpresa { get; set; } = new Empresa();
    public string? ObservacoesFinanceiro { get; set; }
    public int? idFinalidadeCompra { get; set; }
    public bool transp_entregar { get; set; }
    public DateTime? dataAtualizacao { get; set; }
    public decimal? ValorProdutos { get; set; }
    public decimal? ValorServicos { get; set; }
    public decimal? ValorICMS { get; set; }
    public decimal? ValorPIS { get; set; }
    public decimal? ValorCOFINS { get; set; }
    public decimal? ValorST { get; set; }
    public decimal? _valorIPI { get; set; }
    public decimal? ValorIPI { get; set; }
    public decimal? ValorDesconto { get; set; }
    public decimal? ValorFrete { get; set; }
    public decimal? ValorTotal { get; set; }
}
