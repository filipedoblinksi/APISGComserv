using SGComserv.AbstractClass;
using SGComserv.Attributes;
using SGComserv.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGComserv.Entitys;

[Table("tb_pedidos")]
public class PedidoEntity : BaseEntity<PedidoEntity>
{
    public PedidoEntity()
    {
        Nullable<DateTime> datanull = DateTime.Now;
        Id = 0;
        DataCriacao = datanull;
        IdCriador = 0;
        IdCliente = 0;
        Observacoes = "";
        DataEntrega = null;
        IdTipoEntrega = 4;
        IdTipoPedido = 0;
        ValorTotal = 0;
        ValorDesconto = 0;
        ValorFrete = 0;
        Excluido = false;
        DataFechamento = null;
        IdUsuarioFechamento = 0;
        NroNFE = 0;
        PedidoAberto = false;
        UsuarioAberto = 0;
        IdTipoVenda = EModoFaturamento.NFCE;
        idTranspNFe = 0;
        pagamentoFrete = 0;
        transp_placa = "";
        transp_uf = "";
        transp_rntc = "";
        nnfe_venda = 0;
        envnfe_venda = 0;
        tpFornNFe = 0;
        IdEmpresa = 1;
        ObservacoesFinanceiro = "";
        transp_entregar = false;
        ValorICMS = 0;
        valorDifal = 0;
        ValorIPI = 0;
        ValorPIS = 0;
        ValorCOFINS = 0;
        ValorST = 0;
        ValorTotal = 0;
    }

    [Key, Display(Name = "Pedido", Description = "", AutoGenerateField = true)]
    public int Id { get; set; }

    [Display(Name = "Criacao", Description = "", AutoGenerateField = true)]
    public DateTime? DataCriacao { get; set; }

    [Display(Name = "ID Criador", Description = "", AutoGenerateField = true)]
    public int? IdCriador { get; set; }

    [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public virtual UsuarioEntity DadosUsuarioCriacao { get; set; } = new UsuarioEntity();

    [Display(Name = "ID", Description = "", AutoGenerateField = true)]
    private int _idCliente;
    public int IdCliente { get => _idCliente; set => SetProperty(ref _idCliente, value, nameof(IdCliente)); }

    private ClienteEntity _dadosCliente = new ClienteEntity(); 
    [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public virtual ClienteEntity DadosCliente
    {
        get => _dadosCliente; set => SetProperty(ref _dadosCliente, value, nameof(DadosCliente));
    }

    [Display(Name = "Observacoes", Description = "", AutoGenerateField = true)]
    public string Observacoes { get; set; }

    [Display(Name = "Entrega", Description = "", AutoGenerateField = true)]
    public DateTime? DataEntrega { get; set; }

    [Display(Name = "IdTipoEntrega", Description = "", AutoGenerateField = true)]
    public int? IdTipoEntrega { get; set; }

    [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public virtual TipoEntregaEntity DadosTipoEntrega { get; set; } = new TipoEntregaEntity();

    private ETipoPedido _idTipoPedido;
    [Display(Name = "IdTipoPedido", Description = "", AutoGenerateField = true)]
    public ETipoPedido IdTipoPedido { get => _idTipoPedido; set => SetProperty(ref _idTipoPedido, value, nameof(IdTipoPedido)); }

    [Display(Name = "IdFormaPagamento", Description = "", AutoGenerateField = true)]
    public EFormaPagamento? IdFormaPagamento { get; set; }

    [Display(Name = "DataFechamento", Description = "", AutoGenerateField = true)]
    public DateTime? DataFechamento { get; set; }

    [Display(Name = "IdUsuarioFechamento", Description = "", AutoGenerateField = true)]
    public int? IdUsuarioFechamento { get; set; }

    [Display(Name = "NroNFE", Description = "", AutoGenerateField = true)]
    public int? NroNFE { get; set; }

    [Display(Name = "PedidoAberto", Description = "", AutoGenerateField = true)]
    public bool PedidoAberto { get; set; }

    [Display(Name = "UsuarioAberto", Description = "", AutoGenerateField = true)]
    public int? UsuarioAberto { get; set; }

    [Display(Name = "Data Abertura", Description = "", AutoGenerateField = false)]
    public DateTime? dataAbertura { get; set; }

    [Display(Name = "Excluido", Description = "", AutoGenerateField = false)]
    public bool? Excluido { get; set; }

    [Display(Name = "Id Usuario Excluido", Description = "", AutoGenerateField = false)]
    public int? idUsuarioExcluido { get; set; }

    [Display(Name = "Data Excluido", Description = "", AutoGenerateField = false)]
    public DateTime? dataExcluido { get; set; }

    private EModoFaturamento _idTipoVenda;
    [Display(Name = "Tipo Venda", Description = "", AutoGenerateField = true)]
    public EModoFaturamento IdTipoVenda { get => _idTipoVenda; set => SetProperty(ref _idTipoVenda, value, nameof(IdTipoVenda)); }

    [Display(Name = "tpFornNFe ", Description = "", AutoGenerateField = false)]
    public int? tpFornNFe { get; set; }

    [Display(Name = "id. Transp. Nota Fiscal", Description = "", AutoGenerateField = false)]
    public int? idTranspNFe { get; set; }

    [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public FornecedorEntity DadosTranspNFe { get; set; } = new FornecedorEntity();

    [Display(Name = "Pagamento NFE", Description = "", AutoGenerateField = false)]
    public int? pagamentoFrete { get; set; }

    [Display(Name = "transp_uf", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? transp_uf { get; set; }

    [Display(Name = "transp_placa", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? transp_placa { get; set; }

    [Display(Name = "transp_rntc", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? transp_rntc { get; set; }

    [Display(Name = "nnfe_venda", Description = "", AutoGenerateField = false)]
    public int? nnfe_venda { get; set; }

    [Display(Name = "envnfe_venda", Description = "", AutoGenerateField = false)]
    public int? envnfe_venda { get; set; }

    [Display(Name = "DIFAL Venda", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? valorDifal { get; set; }

    [Display(Name = "ent_cnpj", Description = "", AutoGenerateField = false)]
    [MaxLength(20, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? ent_cnpj { get; set; }

    [Display(Name = "ent_nomeRua", Description = "", AutoGenerateField = false)]
    [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? ent_nomeRua { get; set; }

    [Display(Name = "ent_numero", Description = "", AutoGenerateField = false)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? ent_numero { get; set; }

    [Display(Name = "ent_cep", Description = "", AutoGenerateField = false)]
    [MaxLength(12, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? ent_cep { get; set; }

    [Display(Name = "ent_complemento", Description = "", AutoGenerateField = false)]
    [MaxLength(120, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? ent_complemento { get; set; }

    [Display(Name = "ent_bairro", Description = "", AutoGenerateField = false)]
    [MaxLength(120, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? ent_bairro { get; set; }

    [Display(Name = "ent_cidade", Description = "", AutoGenerateField = false)]
    [MaxLength(120, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? ent_cidade { get; set; }

    [Display(Name = "ent_estado", Description = "", AutoGenerateField = false)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? ent_estado { get; set; }

    [Display(Name = "ent_logradouro", Description = "", AutoGenerateField = false)]
    [MaxLength(15, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? ent_logradouro { get; set; }

    [Display(Name = "idEmpresa", Description = "", AutoGenerateField = true)]
    public int IdEmpresa { get; set; }

    [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public virtual EmpresaEntity DadosEmpresa { get; set; } = new EmpresaEntity();

    [Display(Name = "ObservacoesFinanceiro", Description = "", AutoGenerateField = false)]
    public string? ObservacoesFinanceiro { get; set; }

    [Display(Name = "idFinalidadeCompra", Description = "", AutoGenerateField = false)]
    public int? idFinalidadeCompra { get; set; }

    [Display(Name = "transp_entregar", Description = "", AutoGenerateField = false)]
    public bool transp_entregar { get; set; }

    [Display(Name = "Data Atualizacao Preço Pedido", Description = "", AutoGenerateField = true)]
    public DateTime? dataAtualizacao { get; set; }

    private decimal? _valorProdutos;
    [Display(Name = "Valor Produtos", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorProdutos { get => _valorProdutos; set => SetProperty(ref _valorProdutos, value, nameof(ValorProdutos)); }

    private decimal? _valorServicos;
    [Display(Name = "Valor Servicos", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorServicos { get => _valorServicos; set => SetProperty(ref _valorServicos, value, nameof(ValorServicos)); }

    private decimal? _valorICMS;
    [Display(Name = "ICMS Venda", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorICMS { get => _valorICMS; set => SetProperty(ref _valorICMS, value, nameof(ValorICMS)); }

    private decimal? _valorPIS;
    [Display(Name = "PIS Venda", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorPIS { get => _valorPIS; set => SetProperty(ref _valorPIS, value, nameof(ValorPIS)); }

    private decimal? _valorCOFINS;
    [Display(Name = "COFINS Venda", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorCOFINS { get => _valorCOFINS; set => SetProperty(ref _valorCOFINS, value, nameof(ValorCOFINS)); }

    private decimal? _valorST;
    [Display(Name = "Vlr. ST", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorST { get => _valorST; set => SetProperty(ref _valorST, value, nameof(ValorST)); }

    private decimal? _valorIPI;
    [Display(Name = "Vlr IPI", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorIPI { get => _valorIPI; set => SetProperty(ref _valorIPI, value, nameof(ValorIPI)); }

    private decimal? _valorDesconto;
    [Display(Name = "Vlr. Desconto", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorDesconto { get => _valorDesconto; set => SetProperty(ref _valorDesconto, value, nameof(ValorDesconto)); }

    private decimal? _valorFrete;
    [Display(Name = "ValorFrete", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorFrete { get => _valorFrete; set => SetProperty(ref _valorFrete, value, nameof(ValorFrete)); }

    private decimal? _valorTotal;
    [Display(Name = "Valor", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal? ValorTotal { get => _valorTotal; set => SetProperty(ref _valorTotal, value, nameof(ValorTotal)); }

    private bool _solicitacaoAprovacao = false;
    [Display(Name = "Solicitação de Aprovação", Description = "", AutoGenerateField = true)]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public bool SolicitacaoAprovacao { get => _solicitacaoAprovacao; set => SetProperty(ref _solicitacaoAprovacao, value, nameof(SolicitacaoAprovacao)); }
}

