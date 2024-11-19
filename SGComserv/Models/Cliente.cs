using SGComserv.Enums;
using SGComserv.Extensions;

namespace SGComserv.Models;

public class Cliente {
    public int Id { get; set; }
    public string? Fantasia { get; set; }
    public string? RazaoSocial { get; set; }
    public ETipoPessoa TipoPessoa { get; set; }
    public string? Cnpj { get; set; }
    public string? Ie { get; set; }
    public string? End_nomerua { get; set; }
    public string? End_numero { get; set; }
    public string? End_cep { get; set; }
    public string? End_complemento { get; set; }
    public string? End_bairro { get; set; }
    public string? End_cidade { get; set; }
    public int End_cmun { get; set; }
    public string? End_estado { get; set; }
    public Cidade CidadeCadastro { get; set; } = new Cidade();
    public Cidade CidadeCobranca { get; set; } = new Cidade();
    public Cidade CidadeEntrega { get; set; } = new Cidade();
    public Fornecedor Vendedor { get; set; } = new Fornecedor();
    public ClasseCliente ClasseDoCliente { get; set; } = new ClasseCliente();
    public SetorEntrega SetorEntregaCliente { get; set; } = new SetorEntrega();
    public string? Email { get; set; }
    public string? Site { get; set; }
    public string? Telefone { get; set; }
    public string? Fax { get; set; }
    public string? End_logradouro { get; set; }
    public string? EnderecoCompleto {
        get {
            return End_logradouro + " " + End_nomerua + ", " + End_numero + " " + End_complemento + " - " + End_bairro + " - " + End_cidade + " - " + End_estado + " - CEP: " + End_cep;
        }

    }
    public string? Observacoes { get; set; }
    public string nomeVendedor { get { return Vendedor?.fantasia ?? ""; } }
    public int? IdVendedor { get; set; }
    public double? Comissao { get; set; }
    public ESubTabela IdTabela { get; set; }
    public string? DescricaoTabela { get { return IdTabela.GetDescription().ToUpper(); } }
    public int? IdClasse { get; set; }
    public string? DescricaoClasse { get { return ClasseDoCliente?.Descricao ?? string.Empty; } }
    public string? Ent_cnpj { get; set; }
    public string? Ent_nomeRua { get; set; }
    public string? Ent_numero { get; set; }
    public string? Ent_cep { get; set; }
    public string? Ent_complemento { get; set; }
    public string? Ent_bairro { get; set; }
    public int Ent_cmun { get; set; }
    public string? Ent_cidade { get; set; }
    public string? Ent_estado { get; set; }
    public string? Ent_logradouro { get; set; }
    public int? IdSetor { get; set; }
    public string? DescricaoSetor { get { return SetorEntregaCliente?.Descricao ?? string.Empty; } }
    public string? Ent_email { get; set; }
    public string? Cob_logradouro { get; set; }
    public string? Cob_nomeRua { get; set; }
    public string? Cob_numero { get; set; }
    public string? Cob_cep { get; set; }
    public string? Cob_complemento { get; set; }
    public string? Cob_bairro { get; set; }
    public int Cob_cmun { get; set; }
    public string? Cob_cidade { get; set; }
    public string? Cob_estado { get; set; }
    public string? Cob_alertaVendas { get; set; }
    public string? Cob_observacoes { get; set; }
    public string? Cob_email { get; set; }
    public double? Limite { get; set; }
    public string? Serasa { get; set; }
    public DateTime? DataFundacao { get; set; }
    public DateTime? DataCadastro { get; set; }
    public DateTime? DataAtualizacao { get; set; }
    public DateTime? DataUltimaCompra { get; set; }
    public decimal? CapitalSocial { get; set; }
    public EStatusCliente StatusAtivo { get; set; }
    public string? StatusPreco {
        get {
            string? retorno = string.Empty;

            switch (solicitacaoAprovacaoTabela) {
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
                    retorno = string.Empty;
                    break;
            }

            return retorno;
        }
    }
    public string? StatusDescricao {
        get {
            string? retorno = "";

            switch (StatusAtivo) {
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
    public int? IdFormaPagamento { get; set; }
    public string? DescricaoFormaPagamento { get; set; }
    public bool Pagamento_carteira { get; set; }
    public bool Pagamento_boleto { get; set; }
    public bool Pagamento_chequeproprio { get; set; }
    public bool Pagamento_chequesocio { get; set; }
    public bool Pagamento_chequeterceiro { get; set; }
    public bool ConsumidorFinal { get; set; }
    public bool Inativo { get; set; }
    public bool AtualizacaoCadastral { get; set; }
    public int IdFinalidadeCompra { get; set; }
    public string? DescricaoFinalidadeCompra {
        get {
            string? retorno = "";

            switch (IdFinalidadeCompra - 1) {
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
    public int suframa { get; set; }
    public bool IsencaoIPI { get; set; }
    public bool IsencaoICMS { get; set; }
    public bool IsencaoCOFINS { get; set; }
    public bool IsencaoPIS { get; set; }
    public bool IsencaoST { get; set; }
    public string? ObservacoesNotaFiscal { get; set; }
    public int IdPais { get; set; }
    public string? NomePais { get; set; }
    public int transp_idTransp { get; set; }
    public int transp_pagamento { get; set; }
    public double transp_valor { get; set; }
    public string? transp_placa { get; set; }
    public string? transp_uf { get; set; }
    public string? transp_rntc { get; set; }
    public bool transp_entregar { get; set; }
    public string? prazoPagamento { get; set; }
    public int diaFechamento { get; set; }
    public int diaPagamento { get; set; }
    public string? cnae { get; set; }
    public decimal descontoLimite { get; set; }
    public decimal descontoPadrao { get; set; }
    public int idPai { get; set; }
    public ESolicitacaoAprovacao solicitacaoAprovacaoTabela { get; set; }
    public DateTime? dataSAprovacaoTabela { get; set; }
    public string? mensagemSAprovacaoTabela { get; set; }
    public int? idUsuarioSAprovacaoTabela { get; set; }
    public string? mensagemAprovacaoTabela { get; set; }
    public DateTime? dataAprovacaoTabela { get; set; }
    public int? idUsuarioAprovacaoTabela { get; set; }
    public string? idPlanoContabil { get; set; }
}
