using SGComserv.AbstractClass;
using SGComserv.Attributes;
using SGComserv.Enums;
using SGComserv.Extensions;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGComserv.Entitys;

[Table("tb_cliente")]
public class ClienteEntity : BaseEntity<ClienteEntity>
{
    private int _id = 0;
    private string _fantasia;
    private string _razaoSocial;
    private ETipoPessoa _tipoPessoa;
    private string _cnpj;
    private string _ie;
    private string? _end_nomerua;
    private string? _end_numero;
    private string? _end_cep;
    private string? _end_complemento;
    private string? _end_bairro;
    private string? _end_cidade;
    private int _end_cmun;
    private string? _end_estado;
    private string? _email;
    private string? _site;
    private string? _telefone;
    private string? _fax;
    private string? end_logradouro;
    private string? _observacoes;
    private int? _idVendedor;
    private double? _comissao;
    private ESubTabela _idTabela;
    private int? _idClasse;
    private string? _ent_cnpj;
    private string? _ent_nomeRua;
    private string? _ent_numero;
    private string? _ent_cep;
    private string? _ent_complemento;
    private string? _ent_bairro;
    private int _ent_cmun;
    private string? _ent_cidade;
    private string? _ent_estado;
    private string? _ent_logradouro;
    private int? _idSetor;
    private string? _ent_email;
    private string? _cob_logradouro;
    private string? _cob_nomeRua;
    private string? _cob_numero;
    private string? _cob_cep;
    private string? _cob_complemento;
    private string? _cob_bairro;
    private int _cob_cmun;
    private string? _cob_cidade;
    private string? _cob_estado;
    private string? _cob_alertaVendas;
    private string? _cob_observacoes;
    private string? _cob_email;
    private double? _limite;
    private string? _serasa;
    private DateTime? _dataFundacao;
    private DateTime? _dataCadastro;
    private DateTime? _dataAtualizacao;
    private DateTime? _dataUltimaCompra;
    private decimal? _capitalSocial;
    private EStatusCliente _statusAtivo;
    private int? _idFormaPagamento;

    [Key, AutoIncrement, Display(Name = "Id", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public int Id { get => _id; set => SetProperty(ref _id, value, nameof(Id)); }

    [Display(Name = "Fantasia", Description = "", AutoGenerateField = true)]
    public string Fantasia { get => _fantasia; set => SetProperty(ref _fantasia, value, nameof(Fantasia)); }

    [Display(Name = "Razão Social", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string RazaoSocial { get => _razaoSocial; set => SetProperty(ref _razaoSocial, value, nameof(RazaoSocial)); }

    [Display(Name = "TipoPessoa", Description = "", AutoGenerateField = true)]
    [MaxLength(1, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public ETipoPessoa TipoPessoa { get => _tipoPessoa; set => SetProperty(ref _tipoPessoa, value, nameof(TipoPessoa)); }

    [Display(Name = "Cnpj", Description = "", AutoGenerateField = true)]
    [MaxLength(20, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string Cnpj { get => _cnpj; set => SetProperty(ref _cnpj, value, nameof(Cnpj)); }

    [Display(Name = "Ie", Description = "", AutoGenerateField = true)]
    [MaxLength(50, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string Ie { get => _ie; set => SetProperty(ref _ie, value, nameof(Ie)); }

    [Display(Name = "End_nomerua", Description = "", AutoGenerateField = true)]
    [MaxLength(80, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? End_nomerua { get => _end_nomerua; set => SetProperty(ref _end_nomerua, value, nameof(End_nomerua)); }

    [Display(Name = "End_numero", Description = "", AutoGenerateField = true)]
    [MaxLength(55, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? End_numero { get => _end_numero; set => SetProperty(ref _end_numero, value, nameof(End_numero)); }

    [Display(Name = "End_cep", Description = "", AutoGenerateField = true)]
    [MaxLength(9, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? End_cep { get => _end_cep; set => SetProperty(ref _end_cep, value, nameof(End_cep)); }

    [Display(Name = "End_complemento", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? End_complemento { get => _end_complemento; set => SetProperty(ref _end_complemento, value, nameof(End_complemento)); }

    [Display(Name = "End_bairro", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? End_bairro { get => _end_bairro; set => SetProperty(ref _end_bairro, value, nameof(End_bairro)); }

    [Display(Name = "Cidade", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? End_cidade { get => _end_cidade; set => SetProperty(ref _end_cidade, value, nameof(End_cidade)); }

    [Display(Name = "IBGE", Description = "", AutoGenerateField = true)]
    public int End_cmun { get => _end_cmun; set => SetProperty(ref _end_cmun, value, nameof(End_cmun)); }

    [Display(Name = "UF", Description = "", AutoGenerateField = true)]
    [MaxLength(2, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? End_estado { get => _end_estado; set => SetProperty(ref _end_estado, value, nameof(End_estado)); }

    [IgnoreOnInsert, IgnoreOnUpdate]
    public CidadeEntity CidadeCadastro { get; set; } = new CidadeEntity();

    [IgnoreOnInsert, IgnoreOnUpdate]
    public CidadeEntity CidadeCobranca { get; set; } = new CidadeEntity();

    [IgnoreOnInsert, IgnoreOnUpdate]
    public CidadeEntity CidadeEntrega { get; set; } = new CidadeEntity();

    [IgnoreOnInsert, IgnoreOnUpdate]
    public FornecedorEntity Vendedor { get; set; } = new FornecedorEntity();

    [IgnoreOnInsert, IgnoreOnUpdate]
    public ClasseClienteEntity ClasseDoCliente { get; set; } = new ClasseClienteEntity();

    [IgnoreOnInsert, IgnoreOnUpdate]
    public SetorEntregaEntity SetorEntregaCliente { get; set; } = new SetorEntregaEntity();

    [Display(Name = "Email", Description = "", AutoGenerateField = true)]
    [MaxLength(180, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Email { get => _email; set => _email = value; }

    [Display(Name = "Site", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Site { get => _site; set => _site = value; }

    [Display(Name = "Telefone", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Telefone { get => _telefone; set => _telefone = value; }

    [Display(Name = "Fax", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Fax { get => _fax; set => _fax = value; }

    [Display(Name = "End_logradouro", Description = "", AutoGenerateField = true)]
    [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? End_logradouro { get => end_logradouro; set => end_logradouro = value; }

    [Display(Name = "Endereço Completo", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    public string? EnderecoCompleto
    {
        get
        {
            return End_logradouro + " " + End_nomerua + ", " + End_numero + " " + End_complemento + " - " + End_bairro + " - " + End_cidade + " - " + End_estado + " - CEP: " + End_cep;
        }

    }

    [Display(Name = "Observacoes", Description = "", AutoGenerateField = true)]
    public string? Observacoes { get => _observacoes; set => _observacoes = value; }

    [Display(Name = "Vendedor", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    public string nomeVendedor { get { return Vendedor?.fantasia ?? ""; } }

    [Display(Name = "IdVendedor", Description = "", AutoGenerateField = true)]
    public int? IdVendedor { get => _idVendedor; set => _idVendedor = value; }

    [Display(Name = "Comissao", Description = "", AutoGenerateField = true)]
    public double? Comissao { get => _comissao; set => _comissao = value; }

    [Display(Name = "IdTabela", Description = "", AutoGenerateField = true)]
    public ESubTabela IdTabela { get => _idTabela; set => _idTabela = value; }

    [Display(Name = "Tabela", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    public string? DescricaoTabela { get { return IdTabela.GetDescription().ToUpper(); } }

    [Display(Name = "IdClasse", Description = "", AutoGenerateField = true)]
    public int? IdClasse { get => _idClasse; set => _idClasse = value; }

    [Display(Name = "Classe", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    public string? DescricaoClasse { get { return ClasseDoCliente?.Descricao ?? ""; } }

    [Display(Name = "ent_cnpj", Description = "", AutoGenerateField = true)]
    [MaxLength(20, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_cnpj { get => _ent_cnpj; set => _ent_cnpj = value; }

    [Display(Name = "Ent_nomeRua", Description = "", AutoGenerateField = true)]
    [MaxLength(250, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_nomeRua { get => _ent_nomeRua; set => _ent_nomeRua = value; }

    [Display(Name = "Ent_numero", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_numero { get => _ent_numero; set => _ent_numero = value; }

    [Display(Name = "Ent_cep", Description = "", AutoGenerateField = true)]
    [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_cep { get => _ent_cep; set => _ent_cep = value; }

    [Display(Name = "Ent_complemento", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_complemento { get => _ent_complemento; set => _ent_complemento = value; }

    [Display(Name = "Ent_bairro", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_bairro { get => _ent_bairro; set => _ent_bairro = value; }

    [Display(Name = "Codigo Cidade Entrega", Description = "", AutoGenerateField = true)]
    public int Ent_cmun { get => _ent_cmun; set => _ent_cmun = value; }

    [Display(Name = "Ent_cidade", Description = "", AutoGenerateField = true)]
    [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_cidade { get => _ent_cidade; set => _ent_cidade = value; }

    [Display(Name = "Ent_estado", Description = "", AutoGenerateField = true)]
    [MaxLength(2, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_estado { get => _ent_estado; set => _ent_estado = value; }

    [Display(Name = "Ent_logradouro", Description = "", AutoGenerateField = true)]
    [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_logradouro { get => _ent_logradouro; set => _ent_logradouro = value; }

    [Display(Name = "ID Setor", Description = "", AutoGenerateField = true)]
    public int? IdSetor { get => _idSetor; set => _idSetor = value; }

    [Display(Name = "Setor Entrega", Description = "", AutoGenerateField = true)]
    [IgnoreOnInsert, IgnoreOnUpdate]
    [NotMapped]
    public string? DescricaoSetor { get { return SetorEntregaCliente?.Descricao ?? ""; } }

    [Display(Name = "Ent_email", Description = "", AutoGenerateField = true)]
    [MaxLength(130, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ent_email { get => _ent_email; set => _ent_email = value; }

    [Display(Name = "Cob_logradouro", Description = "", AutoGenerateField = true)]
    [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cob_logradouro { get => _cob_logradouro; set => _cob_logradouro = value; }

    [Display(Name = "Cob_nomeRua", Description = "", AutoGenerateField = true)]
    [MaxLength(250, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cob_nomeRua { get => _cob_nomeRua; set => _cob_nomeRua = value; }

    [Display(Name = "Cob_numero", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cob_numero { get => _cob_numero; set => _cob_numero = value; }

    [Display(Name = "Cob_cep", Description = "", AutoGenerateField = true)]
    [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cob_cep { get => _cob_cep; set => _cob_cep = value; }

    [Display(Name = "Cob_complemento", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cob_complemento { get => _cob_complemento; set => _cob_complemento = value; }

    [Display(Name = "Cob_bairro", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cob_bairro { get => _cob_bairro; set => _cob_bairro = value; }

    [Display(Name = "Codigo Cidade Cobrança", Description = "", AutoGenerateField = true)]
    public int Cob_cmun { get => _cob_cmun; set => _cob_cmun = value; }

    [Display(Name = "Cob_cidade", Description = "", AutoGenerateField = true)]
    [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cob_cidade { get => _cob_cidade; set => _cob_cidade = value; }

    [Display(Name = "Cob_estado", Description = "", AutoGenerateField = true)]
    [MaxLength(2, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cob_estado { get => _cob_estado; set => _cob_estado = value; }

    [Display(Name = "Cob_alertaVendas", Description = "", AutoGenerateField = true)]
    public string? Cob_alertaVendas { get => _cob_alertaVendas; set => _cob_alertaVendas = value; }

    [Display(Name = "Cob_observacoes", Description = "", AutoGenerateField = true)]
    public string? Cob_observacoes { get => _cob_observacoes; set => _cob_observacoes = value; }

    [Display(Name = "Cob_email", Description = "", AutoGenerateField = true)]
    [MaxLength(130, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cob_email { get => _cob_email; set => _cob_email = value; }

    [Display(Name = "Limite", Description = "", AutoGenerateField = true)]
    public double? Limite { get => _limite; set => _limite = value; }

    [Display(Name = "Serasa", Description = "", AutoGenerateField = true)]
    public string? Serasa { get => _serasa; set => _serasa = value; }

    [Display(Name = "Data Fundação", Description = "", AutoGenerateField = true)]
    public DateTime? DataFundacao { get => _dataFundacao; set => _dataFundacao = value; }

    [Display(Name = "Data Cadastro", Description = "", AutoGenerateField = true)]
    public DateTime? DataCadastro { get => _dataCadastro; set => _dataCadastro = value; }

    [Display(Name = "Data Atualização", Description = "", AutoGenerateField = true)]
    public DateTime? DataAtualizacao { get => _dataAtualizacao; set => _dataAtualizacao = value; }

    [Display(Name = "Última Compra", Description = "", AutoGenerateField = true)]
    public DateTime? DataUltimaCompra { get => _dataUltimaCompra; set => _dataUltimaCompra = value; }

    [Display(Name = "CapitalSocial", Description = "", AutoGenerateField = true)]
    public decimal? CapitalSocial { get => _capitalSocial; set => _capitalSocial = value; }

    [Display(Name = "StatusAtivo", Description = "", AutoGenerateField = true)]
    public EStatusCliente StatusAtivo { get => _statusAtivo; set => _statusAtivo = value; }

    [Display(Name = "Análise", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    public string? StatusPreco
    {
        get
        {
            string? retorno = "";

            switch (solicitacaoAprovacaoTabela)
            {
                case (ESolicitacaoAprovacao.Solicitacao):
                    retorno = "Solic.";
                    break;
                case (ESolicitacaoAprovacao.Aprovado):
                    retorno = "Aprv.";
                    break;
                case (ESolicitacaoAprovacao.Reprovado):
                    retorno = "Repr.";
                    break;
                case (ESolicitacaoAprovacao.SemSolicitacao):
                    retorno = "";
                    break;
            }

            return retorno;
        }
    }

    [Display(Name = "Status", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    public string? StatusDescricao
    {
        get
        {
            string? retorno = "";

            switch (StatusAtivo)
            {
                case EStatusCliente.ok:
                    retorno = "OK";
                    break;
                default:
                    retorno = "SUSPENSO";
                    break;
            }

            return retorno;
        }
    }

    [Display(Name = "IdFormaPagamento", Description = "", AutoGenerateField = true)]
    public int? IdFormaPagamento { get => _idFormaPagamento; set => _idFormaPagamento = value; }

    [Display(Name = "Forma de Pagamento", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    public string? DescricaoFormaPagamento { get; set; }

    [Display(Name = "Pagamento Carteira", Description = "", AutoGenerateField = true)]
    public bool Pagamento_carteira { get; set; }

    [Display(Name = "Pagamento Boleto", Description = "", AutoGenerateField = true)]
    public bool Pagamento_boleto { get; set; }

    [Display(Name = "Pagamento Cheque Proprio", Description = "", AutoGenerateField = true)]
    public bool Pagamento_chequeproprio { get; set; }

    [Display(Name = "Pagamento Cheque Sócio", Description = "", AutoGenerateField = true)]
    public bool Pagamento_chequesocio { get; set; }

    [Display(Name = "Pagamento Cheque Terceiro", Description = "", AutoGenerateField = true)]
    public bool Pagamento_chequeterceiro { get; set; }

    [Display(Name = "Consumidor Final", Description = "", AutoGenerateField = true)]
    public bool ConsumidorFinal { get; set; }

    [Display(Name = "Inativo", Description = "", AutoGenerateField = true)]
    public bool Inativo { get; set; }

    [Display(Name = "Atualização Cadadastral", Description = "", AutoGenerateField = true)]
    public bool AtualizacaoCadastral { get; set; }

    [Display(Name = "Finalidade Compra", Description = "", AutoGenerateField = true)]
    public int IdFinalidadeCompra { get; set; }

    [Display(Name = "Finalidade Compra", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    public string? DescricaoFinalidadeCompra
    {
        get
        {
            string? retorno = "";

            switch (IdFinalidadeCompra - 1)
            {
                case 0:
                    retorno = "Consumo";
                    break;
                case 1:
                    retorno = "Industrialização";
                    break;
                case 2:
                    retorno = "Revenda";
                    break;
                default:
                    retorno = "";
                    break;
            }

            return retorno;
        }
    }

    [Display(Name = "Suframa", Description = "", AutoGenerateField = true)]
    public int suframa { get; set; }

    [Display(Name = "Isencao de IPI", Description = "", AutoGenerateField = true)]
    public bool IsencaoIPI { get; set; }

    [Display(Name = "Isencao de ICMS", Description = "", AutoGenerateField = true)]
    public bool IsencaoICMS { get; set; }

    [Display(Name = "IsencaoCOFINS", Description = "", AutoGenerateField = true)]
    public bool IsencaoCOFINS { get; set; }

    [Display(Name = "Isencao de PIS", Description = "", AutoGenerateField = true)]
    public bool IsencaoPIS { get; set; }

    [Display(Name = "IsencaoST", Description = "", AutoGenerateField = true)]
    public bool IsencaoST { get; set; }

    [Display(Name = "observacoesNotaFiscal", Description = "", AutoGenerateField = true)]
    public string? ObservacoesNotaFiscal { get; set; }

    [Display(Name = "idPais", Description = "", AutoGenerateField = true)]
    public int IdPais { get; set; }

    [Display(Name = "nomePais", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    public string? NomePais { get; set; }

    [Display(Name = "transp_idTransp", Description = "", AutoGenerateField = true)]
    public int transp_idTransp { get; set; }

    [Display(Name = "transp_pagamento", Description = "", AutoGenerateField = true)]
    public int transp_pagamento { get; set; }

    [Display(Name = "transp_valor", Description = "", AutoGenerateField = true)]
    public double transp_valor { get; set; }

    [Display(Name = "transp_placa", Description = "", AutoGenerateField = true)]
    public string? transp_placa { get; set; }

    [Display(Name = "transp_uf", Description = "", AutoGenerateField = true)]
    public string? transp_uf { get; set; }

    [Display(Name = "transp_rntc", Description = "", AutoGenerateField = true)]
    public string? transp_rntc { get; set; }

    [Display(Name = "transp_entregar", Description = "", AutoGenerateField = true)]
    public bool transp_entregar { get; set; }

    [Display(Name = "prazoPagamento", Description = "", AutoGenerateField = true)]
    [MaxLength(255, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? prazoPagamento { get; set; }

    [Display(Name = "Dia Fechamento", Description = "", AutoGenerateField = true)]
    public int diaFechamento { get; set; }

    [Display(Name = "diaPagamento", Description = "", AutoGenerateField = true)]
    public int diaPagamento { get; set; }

    [Display(Name = "CNAE", Description = "", AutoGenerateField = true)]
    public string? cnae { get; set; }

    [Display(Name = "descontoLimite", Description = "", AutoGenerateField = true)]
    public decimal descontoLimite { get; set; }

    [Display(Name = "descontoPadrao", Description = "", AutoGenerateField = true)]
    public decimal descontoPadrao { get; set; }

    [Display(Name = "idPai", Description = "", AutoGenerateField = true)]
    public int idPai { get; set; }

    [Display(Name = "solicitacaoAprovacaoTabela", Description = "", AutoGenerateField = true)]
    public ESolicitacaoAprovacao solicitacaoAprovacaoTabela { get; set; }

    [Display(Name = "dataSAprovacaoTabela", Description = "", AutoGenerateField = true)]
    public DateTime? dataSAprovacaoTabela { get; set; }

    [Display(Name = "mensagemSAprovacaoTabela", Description = "", AutoGenerateField = true)]
    public string? mensagemSAprovacaoTabela { get; set; }

    [Display(Name = "idUsuarioSAprovacaoTabela", Description = "", AutoGenerateField = true)]
    public int? idUsuarioSAprovacaoTabela { get; set; }

    [Display(Name = "mensagemAprovacaoTabela", Description = "", AutoGenerateField = true)]
    public string? mensagemAprovacaoTabela { get; set; }

    [Display(Name = "dataAprovacaoTabela", Description = "", AutoGenerateField = true)]
    public DateTime? dataAprovacaoTabela { get; set; }

    [Display(Name = "idUsuarioAprovacaoTabela", Description = "", AutoGenerateField = true)]
    public int? idUsuarioAprovacaoTabela { get; set; }

    [Display(Name = "Id Plano Contabil", Description = "", AutoGenerateField = true)]
    public string? idPlanoContabil { get; set; }

    public ClienteEntity(int _id) : this()
    {
        this.Id = _id;
    }

    public ClienteEntity()
    {
        Id = 0;
        Fantasia = "";
        RazaoSocial = "";
        TipoPessoa = ETipoPessoa.Fisica;
        Cnpj = "";
        Ie = "";
        End_nomerua = "";
        End_numero = "";
        End_cep = "";
        End_complemento = "";
        End_bairro = "";
        End_cidade = "";
        End_estado = "";
        Email = "";
        Site = "";
        Telefone = "";
        Fax = "";
        End_logradouro = "";
        Observacoes = "";
        IdVendedor = 0;
        Comissao = 0;
        IdTabela = 0;
        IdClasse = 0;
        Ent_nomeRua = "";
        Ent_numero = "";
        Ent_cep = "";
        Ent_complemento = "";
        Ent_bairro = "";
        Ent_cidade = "";
        Ent_estado = "";
        Ent_logradouro = "";
        IdSetor = 0;
        Ent_email = "";
        Cob_logradouro = "";
        Cob_nomeRua = "";
        Cob_numero = "";
        Cob_cep = "";
        Cob_complemento = "";
        Cob_bairro = "";
        Cob_cidade = "";
        Cob_estado = "";
        Cob_alertaVendas = "";
        Cob_observacoes = "";
        Cob_email = "";
        Limite = 0;
        Serasa = "";
        DataCadastro = null;
        DataAtualizacao = null;
        DataUltimaCompra = null;
        CapitalSocial = 0;
        StatusAtivo = 0;
        IdFormaPagamento = 0;
        Pagamento_carteira = false;
        Pagamento_boleto = false;
        Pagamento_chequeproprio = false;
        Pagamento_chequeterceiro = false;
        End_cmun = 0;
        ConsumidorFinal = false;
        Inativo = false;
        AtualizacaoCadastral = false;
        IdFinalidadeCompra = 1;
        ObservacoesNotaFiscal = "";
        suframa = 0;
        IsencaoIPI = false;
        IsencaoCOFINS = false;
        IsencaoICMS = false;
        IsencaoPIS = false;
        IdPais = 1058;
        NomePais = "BRASIL";
        transp_idTransp = 0;
        transp_pagamento = 0;
        transp_valor = 0;
        transp_placa = "";
        transp_uf = "";
        transp_rntc = "";
        transp_entregar = false;
        prazoPagamento = "";
        diaFechamento = 0;
        diaPagamento = 0;
        cnae = "";
        descontoPadrao = 0;
        descontoLimite = 0;
        idPai = 0;
        idPlanoContabil = "";
    }

    public enum ESolicitacaoAprovacao : int
    {
        Solicitacao = 1,
        Aprovado = 2,
        Reprovado = 3,
        SemSolicitacao = 0
    }
}