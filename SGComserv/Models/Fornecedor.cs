using SGComserv.Enums;

namespace SGComserv.Models;

public class Fornecedor {
    public int id { get; set; }
    public string? fantasia { get; set; }
    public string? razaoSocial { get; set; }
    public ETipoEntidade idTipoFornecedor { get; set; }
    public ETipoPessoa tipoPessoa { get; set; }
    public string? cnpj { get; set; }
    public string? ie { get; set; }
    public string? end_nomerua { get; set; }
    public string? end_numero { get; set; }
    public string? end_cep { get; set; }
    public string? end_complemento { get; set; }
    public string? end_bairro { get; set; }
    public int? end_cmun { get; set; }
    public string? end_cidade { get; set; }
    public string? end_estado { get; set; }
    public string? enderecoCompleto {
        get {
            return end_logradouro + " " + end_nomerua + ", " + end_numero + " " + end_complemento + " - " + end_bairro + " - " + end_cidade + " - " + end_estado + " - CEP: " + end_cep;
        }

    }
    public string? email { get; set; }
    public string? site { get; set; }
    public string? telefone { get; set; }
    public string? fax { get; set; }
    public string? end_logradouro { get; set; }
    public string? observacoes { get; set; }
    public int idClasse { get; set; }
    public virtual ClasseFornecedor DadosClasseFornecedor { get; set; } = new ClasseFornecedor();
    public string? inscricaoMunicipal { get; set; }
    public ETipoRegimeTributario regimeTributario { get; set; }
    public string? chavePix { get; set; }
    public ETipoChavePix idTipoChavePix { get; set; }
    public string? nomeBanco { get; set; }
    public string? nroBanco { get; set; }
    public string? agencia { get; set; }
    public string? contaCorrente { get; set; }
    public string? gerenteBanco { get; set; }
    public string? telefoneBanco { get; set; }
    public DateTime? dataCadastro { get; set; }
    public string? usuarioCadastro { get; set; }
    public DateTime? dataAtualizacao { get; set; }
    public string? usuarioAtualizacao { get; set; }
    public decimal comissaoVendedor { get; set; }
    public decimal comissaoSecundario { get; set; }
    public decimal comissaoAtendente { get; set; }
    public decimal percentualFaturamento { get; set; }
    public decimal percentualRecebimento { get; set; }
    public int idEmpresa { get; set; }
    public virtual Empresa DadosEmpresa { get; set; } = new Empresa();
    public int idTipoGasto { get; set; }
    public virtual TipoGasto? DadosTipoGasto { get; set; }
    public int idCTipoPagamento { get; set; }
    public virtual TipoDocumentoFinanceiro? DadosTipoDocumentoFinanceiro { get; set; }
    public string? IdPlanoFinanceiro { get; set; }
    public virtual PlanoFinanceiro? DadosPlanoFinanceiro { get; set; }
    public string? observacoesPagamento { get; set; }
    public int idPais { get; set; }
    public bool inativo { get; set; }
    public string? idContabilFornecedor { get; set; }
    public virtual PlanoContabil? DadosPlanoContabil { get; set; }
    public string? prazoPagamento { get; set; }
    public EFormaPagamento idFormaPagamento { get; set; }
    public string? contatoFornecedor {
        get {
            return fantasia + (!string.IsNullOrEmpty(telefone) && telefone.Replace(" ", "") != "()-" ? " - " + telefone : "") + (!string.IsNullOrEmpty(email) ? " - " + email : "");
        }
    }
}
