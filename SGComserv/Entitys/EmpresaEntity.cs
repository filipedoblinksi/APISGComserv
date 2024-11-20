using SGComserv.AbstractClass;
using SGComserv.Attributes;
using SGComserv.Enums;
using SGComserv.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGComserv.Entitys;

[Table("tb_empresas")]
public class EmpresaEntity : BaseEntity<EmpresaEntity>
{
    [Key, AutoIncrement, Display(Name = "Id", Description = "", AutoGenerateField = true)]
    public int Id { get; set; }

    [Display(Name = "Nome", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Nome { get; set; }

    [Display(Name = "Telefone", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Telefone { get; set; }

    [Display(Name = "Fax", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Fax { get; set; }

    [Display(Name = "Endereço", Description = "", AutoGenerateField = true)]
    public string? Endereco { get; set; }

    [Display(Name = "Id Empresa Desenvolvimento", Description = "", AutoGenerateField = true)]
    public int IdEmpresaDesenvolvimento { get; set; }

    [Display(Name = "Ultimo Contas Fixas", Description = "", AutoGenerateField = true)]
    public DateTime? UltimoContasFixas { get; set; }

    [Display(Name = "Ultima Nota Fiscal Emitida", Description = "", AutoGenerateField = true)]
    public int UltimaNotaFiscalEmitida { get; set; }

    [Display(Name = "Ultimo M D Fe Emitido", Description = "", AutoGenerateField = true)]
    public int UltimoMDFeEmitido { get; set; }

    [Display(Name = "Ult N S U", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? UltNSU { get; set; }

    [Display(Name = "Aliquota I C M S", Description = "", AutoGenerateField = true)]
    public double AliquotaICMS { get; set; }

    [Display(Name = "Mensagem", Description = "", AutoGenerateField = true)]
    public string? Mensagem { get; set; }

    [Display(Name = "Tipo Regime", Description = "", AutoGenerateField = true)]
    public int TipoRegime { get; set; }

    [Display(Name = "Cnpj", Description = "", AutoGenerateField = true)]
    [MaxLength(20, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cnpj { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "CnpjSemFormatacao", Description = "", AutoGenerateField = true)]
    public string? CnpjSemFormatacao { get { return this.Cnpj.RemoveFormat(); } }

    [Display(Name = "Ie", Description = "", AutoGenerateField = true)]
    [MaxLength(25, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Ie { get; set; }

    [Display(Name = "Nome Rua", Description = "", AutoGenerateField = true)]
    [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? NomeRua { get; set; }

    [Display(Name = "Numero", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Numero { get; set; }

    [Display(Name = "Complemento", Description = "", AutoGenerateField = true)]
    [MaxLength(60, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Complemento { get; set; }

    [Display(Name = "Bairro", Description = "", AutoGenerateField = true)]
    [MaxLength(160, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Bairro { get; set; }

    [Display(Name = "Cidade", Description = "", AutoGenerateField = true)]
    [MaxLength(160, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cidade { get; set; }

    [Display(Name = "Estado", Description = "", AutoGenerateField = true)]
    [MaxLength(2, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Estado { get; set; }

    [Display(Name = "Razao Social", Description = "", AutoGenerateField = true)]
    [MaxLength(150, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? RazaoSocial { get; set; }

    [Display(Name = "Inscricao Municipal", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? InscricaoMunicipal { get; set; }

    [Display(Name = "Cnae", Description = "", AutoGenerateField = true)]
    [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cnae { get; set; }

    [Display(Name = "Cep", Description = "", AutoGenerateField = true)]
    [MaxLength(9, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Cep { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "Pais", Description = "", AutoGenerateField = true)]
    [MaxLength(130, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Pais { get; set; }

    [Display(Name = "Imagem Padrao", Description = "", AutoGenerateField = true)]
    public byte[]? ImagemPadrao { get; set; }

    [Display(Name = "Observacoes", Description = "", AutoGenerateField = true)]
    public string? Observacoes { get; set; }

    [Display(Name = "Email", Description = "", AutoGenerateField = true)]
    [MaxLength(80, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Email { get; set; }

    [Display(Name = "site", Description = "", AutoGenerateField = true)]
    public string? Site { get; set; }

    [Display(Name = "Tipo Pessoa", Description = "", AutoGenerateField = true)]
    public int TipoPessoa { get; set; }

    [Display(Name = "Validacao", Description = "", AutoGenerateField = true)]
    [MaxLength(130, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Validacao { get; set; }

    [Display(Name = "Logradouro", Description = "", AutoGenerateField = true)]
    [MaxLength(80, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Logradouro { get; set; }

    [Display(Name = "Logo", Description = "", AutoGenerateField = true)]
    public byte[]? Logo { get; set; }

    [Display(Name = "Ultimo Lote N Fe", Description = "", AutoGenerateField = true)]
    public int UltimoLoteNFe { get; set; }

    [Display(Name = "Msg Impressao 1", Description = "", AutoGenerateField = true)]
    [MaxLength(150, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? MsgImpressao1 { get; set; }

    [Display(Name = "Msg Impressao 2", Description = "", AutoGenerateField = true)]
    [MaxLength(150, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? MsgImpressao2 { get; set; }

    [Display(Name = "Cnpj Sastec", Description = "", AutoGenerateField = true)]
    [MaxLength(20, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? CnpjSastec { get; set; }

    [Display(Name = "Assinatura", Description = "", AutoGenerateField = true)]
    public string? Assinatura { get; set; }

    [Display(Name = "Planodefundo", Description = "", AutoGenerateField = true)]
    public int Planodefundo { get; set; }

    [Display(Name = "Modoplanodefundo", Description = "", AutoGenerateField = true)]
    public int Modoplanodefundo { get; set; }

    [Display(Name = "Msg Impressao Pedido", Description = "", AutoGenerateField = true)]
    public string? MsgImpressaoPedido { get; set; }

    [Display(Name = "Msg Impressao Orcamento", Description = "", AutoGenerateField = true)]
    public string? MsgImpressaoOrcamento { get; set; }

    [Display(Name = "Homologacao", Description = "", AutoGenerateField = true)]
    public int Homologacao { get; set; }

    [Display(Name = "Contabil _ Razao Social", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_RazaoSocial { get; set; }

    [Display(Name = "Contabil _cnpj", Description = "", AutoGenerateField = true)]
    [MaxLength(20, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_cnpj { get; set; }

    [Display(Name = "Contabil _crc", Description = "", AutoGenerateField = true)]
    [MaxLength(20, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_crc { get; set; }

    [Display(Name = "Contabil _end _logradouro", Description = "", AutoGenerateField = true)]
    [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_end_logradouro { get; set; }

    [Display(Name = "Contabil _end _nomerua", Description = "", AutoGenerateField = true)]
    [MaxLength(80, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_end_nomerua { get; set; }

    [Display(Name = "Contabil _end _numero", Description = "", AutoGenerateField = true)]
    [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_end_numero { get; set; }

    [Display(Name = "Contabil _end _cep", Description = "", AutoGenerateField = true)]
    [MaxLength(9, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_end_cep { get; set; }

    [Display(Name = "Contabil _end _complemento", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_end_complemento { get; set; }

    [Display(Name = "Contabil _end _bairro", Description = "", AutoGenerateField = true)]
    [MaxLength(160, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_end_bairro { get; set; }

    [Display(Name = "Contabil _end _cidade", Description = "", AutoGenerateField = true)]
    [MaxLength(150, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_end_cidade { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "Contabil _end _estado", Description = "", AutoGenerateField = true)]
    [MaxLength(2, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_end_estado { get; set; }

    [Display(Name = "Contabil _email", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_email { get; set; }

    [Display(Name = "Contabil _telefone", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_telefone { get; set; }

    [Display(Name = "Contabil _fax", Description = "", AutoGenerateField = true)]
    [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Contabil_fax { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "DMunicipio", Description = "", AutoGenerateField = true)]
    public string? DMunicipio { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "Cmunicipio", Description = "", AutoGenerateField = true)]
    public int Cmunicipio { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "Cuf", Description = "", AutoGenerateField = true)]
    public int Cuf { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "IdMunicipio", Description = "", AutoGenerateField = true)]
    public string? IdMunicipio { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "Suf", Description = "", AutoGenerateField = true)]
    public string? Suf { get; set; }

    [Display(Name = "CodigoPais", Description = "", AutoGenerateField = true)]
    public int CodigoPais { get; set; }

    [Display(Name = "cofins", Description = "", AutoGenerateField = true)]
    public decimal Cofins { get; set; }

    [Display(Name = "pis", Description = "", AutoGenerateField = true)]
    public decimal Pis { get; set; }

    [Display(Name = "ultimoNFCeEmitido", Description = "", AutoGenerateField = true)]
    public int UltimoNFCeEmitido { get; set; }

    [Display(Name = "vinco_IdKeyPartner", Description = "", AutoGenerateField = true)]
    [MaxLength(60, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Vinco_IdKeyPartner { get; set; }

    [Display(Name = "vinco_PartnerAuthorizationToken", Description = "", AutoGenerateField = true)]
    [MaxLength(60, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Vinco_PartnerAuthorizationToken { get; set; }

    [Display(Name = "vinco_IdKeyEmpresa", Description = "", AutoGenerateField = true)]
    [MaxLength(60, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Vinco_IdKeyEmpresa { get; set; }

    [Display(Name = "vinco_IUC", Description = "", AutoGenerateField = true)]
    [MaxLength(60, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Vinco_IUC { get; set; }

    [Display(Name = "migrate_chaveAcesso", Description = "", AutoGenerateField = true)]
    [MaxLength(60, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Migrate_chaveAcesso { get; set; }

    [Display(Name = "Série NFe", Description = "", AutoGenerateField = true)]
    public int SerieNFE { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "Habilitada", Description = "", AutoGenerateField = true)]
    public bool Habilitada { get; set; }

    [Display(Name = "ID Banco Boleto Padrão", Description = "", AutoGenerateField = true)]
    public int IdBancoBoletoPadrao { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "Banco Boleto Padrão", Description = "", AutoGenerateField = true)]
    public string? DescricaoBancoBoletoPadrao { get; set; }

    [Display(Name = "ID Banco Boleto Secundário", Description = "", AutoGenerateField = true)]
    public int IdBancoBoletoSecundario { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
    [Display(Name = "Banco Boleto Secundário", Description = "", AutoGenerateField = true)]
    public string? DescricaoBancoBoletoSecundario { get; set; }

    [Display(Name = "Tipo Empresa", Description = "", AutoGenerateField = true)]
    public ETipoEmpresa IdTipoEmpresa { get; set; }

    [Display(Name = "Tabela Venda", Description = "", AutoGenerateField = true)]
    public int IdTabelaVenda { get; set; }

    [Display(Name = "Chave Acesso Homologação", Description = "", AutoGenerateField = true)]
    public string? Migrate_chaveAcesso_homologacao { get; set; }

    [Display(Name = "Homologação Migrate", Description = "", AutoGenerateField = true)]
    public bool Migrate_ambiente_homologacao { get; set; }

    [Display(Name = "padraoEmissaoNFs", Description = "", AutoGenerateField = false)]
    public int PadraoEmissaoNFs { get; set; }

    [Display(Name = "serieNFS", Description = "", AutoGenerateField = false)]
    public string? SerieNFS { get; set; }

    [Display(Name = "versaoLayoutSat", Description = "", AutoGenerateField = true)]
    public string? VersaoLayoutSat { get; set; }

    [Display(Name = "Incentivador Cultural", Description = "", AutoGenerateField = true)]
    public int IncCultural { get; set; }

    [Display(Name = "Última Nota Fiscal de Serviço Emitida", Description = "", AutoGenerateField = true)]
    public int UltimaNotaFiscalServicoEmitida { get; set; }

    [Display(Name = "Último RPS utilizado", Description = "", AutoGenerateField = true)]
    public int UltimoRPS { get; set; }
    public int IdModelo { get; set; }

    public override string? ToString()
    {
        return Nome;
    }

    public EmpresaEntity()
    {
        Id = -1;
        Nome = "";
        Telefone = "";
        Fax = "";
        Endereco = "";
        IdEmpresaDesenvolvimento = 0;
        UltimoContasFixas = DateTime.Now;
        UltimaNotaFiscalEmitida = 0;
        UltimoMDFeEmitido = 0;
        UltNSU = "";
        AliquotaICMS = 0;
        Mensagem = "";
        TipoRegime = 0;
        Cnpj = "";
        Ie = "";
        NomeRua = "";
        Numero = "";
        Complemento = "";
        Bairro = "";
        Cidade = "";
        Estado = "";
        RazaoSocial = "";
        InscricaoMunicipal = "";
        Cnae = "";
        Cep = "";
        Pais = "";
        ImagemPadrao = null;
        Observacoes = "";
        Email = "";
        TipoPessoa = 0;
        Validacao = "";
        Logradouro = "";
        Logo = null;
        UltimoLoteNFe = 0;
        MsgImpressao1 = "";
        MsgImpressao2 = "";
        CnpjSastec = "";
        Assinatura = "";
        Planodefundo = 0;
        Modoplanodefundo = 0;
        MsgImpressaoPedido = "";
        MsgImpressaoOrcamento = "";
        Homologacao = 0;
        Contabil_RazaoSocial = "";
        Contabil_cnpj = "";
        Contabil_crc = "";
        Contabil_end_logradouro = "";
        Contabil_end_nomerua = "";
        Contabil_end_numero = "";
        Contabil_end_cep = "";
        Contabil_end_complemento = "";
        Contabil_end_bairro = "";
        Contabil_end_cidade = "";
        Contabil_end_estado = "";
        Contabil_email = "";
        Contabil_telefone = "";
        Contabil_fax = "";
        Pis = 0;
        Cofins = 0;
        Vinco_IdKeyPartner = "";
        Vinco_PartnerAuthorizationToken = "";
        Vinco_IdKeyEmpresa = "";
        Vinco_IUC = "";
        SerieNFE = 1;
        IdTipoEmpresa = ETipoEmpresa.Matriz;
        Site = "";
        IdModelo = 0;
    }
}