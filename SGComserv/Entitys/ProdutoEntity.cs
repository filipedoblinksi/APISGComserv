using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SGComserv.AbstractClass;
using SGComserv.Attributes;
using SGComserv.Enums;

namespace SGComserv.Entitys
{
    [Table("tb_produtos")]
    public class ProdutoEntity : BaseEntity<ProdutoEntity>
    {
        public ProdutoEntity()
        {
            Nullable<DateTime> _data_null = new Nullable<DateTime>();
            _data_null = null;

            this.IdProduto = -1;
            this.IdGrupo = 0;
            this.DescricaoGrupo = string.Empty;
            this.IdUnidade = string.Empty;
            this.Descricao = string.Empty;
            this.Linha = 0;
            this.Custo = 0;
            this.Peso = 0;
            this.Ncm = string.Empty;
            this.BaixoGiro = false;
            this.Ean13 = string.Empty;
            this.IdTipoProduto = 0;
            this.DescricaoTipoProduto = string.Empty;
            this.Importacao = 0;
            this.Imagem = null;
            this.IpiVenda = 0;
            this.Ipi = 0;
            this.St = 0;
            this.Difal = 0;
            this.Cest = string.Empty;
            this.Inativo = false;
            this.StOrigem = false;
            this.DataCadastro = _data_null;
            this.DataAtualizacao = _data_null;
            this.UsuarioCadastro = string.Empty;
            this.UsuarioAtualizacao = string.Empty;
            this.IdPlanoContabil = string.Empty;
            this.IdFabricante = 0;
            this.DescricaoFabricante = string.Empty;
            this.CstPIS = ECstPis.Item00;
            this.CstCOFINS = ECstCofins.Item00;
            this.ControleEstoque = true;
            this.IdSegmento = 1;
        }

        [Key, Display(Name = "Codigo", Description = "", AutoGenerateField = true)]
        public int IdProduto { get; set; }

        [Display(Name = "Descrição", Description = "", AutoGenerateField = true)]
        [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public string? Descricao { get; set; }

        [Display(Name = "ID Grupo", Description = "", AutoGenerateField = true)]
        public int IdGrupo { get; set; }

        [Display(Name = "Grupo", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        public string? DescricaoGrupo { get; set; }

        [Display(Name = "Uni.", Description = "", AutoGenerateField = true)]
        [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public string? IdUnidade { get; set; }

        [Display(Name = "Linha (ID)", Description = "", AutoGenerateField = true)]
        public int Linha { get; set; }

        [Display(Name = "Linha", Description = "", AutoGenerateField = true)]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        public string? DescricaoLinha { get; set; }

        [Display(Name = "Custo", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal Custo { get; set; }

        [Display(Name = "Custo Medio", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal CustoMedio { get; set; }

        [Display(Name = "Custo Total", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal CustoTotal { get; set; }

        [Display(Name = "Peso", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N3", ApplyFormatInEditMode = true)]
        public decimal Peso { get; set; }

        [Display(Name = "NCM", Description = "", AutoGenerateField = true)]
        [MaxLength(9, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public string Ncm { get; set; }

        [Display(Name = "Baixo Giro", Description = "", AutoGenerateField = true)]
        public bool BaixoGiro { get; set; }

        [Display(Name = "EAN 13", Description = "", AutoGenerateField = true)]
        [MaxLength(13, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public string? Ean13 { get; set; }

        [Display(Name = "Id Tipo Produto", Description = "", AutoGenerateField = true)]
        public int IdTipoProduto { get; set; }

        [Display(Name = "Tipo Produto", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        public string? DescricaoTipoProduto { get; set; }

        [Display(Name = "Importacao", Description = "", AutoGenerateField = true)]
        public int Importacao { get; set; }

        [Display(Name = "ST Origem", Description = "", AutoGenerateField = false)]
        public bool StOrigem { get; set; }

        [Display(Name = "Imagem", Description = "", AutoGenerateField = true)]
        public Byte[]? Imagem { get; set; }

        [Display(Name = "IPI", Description = "", AutoGenerateField = true)]
        public decimal Ipi { get; set; }

        [Display(Name = "ST", Description = "", AutoGenerateField = true)]
        public decimal St { get; set; }

        [Display(Name = "Difal", Description = "", AutoGenerateField = true)]
        public decimal Difal { get; set; }

        [Display(Name = "CEST", Description = "", AutoGenerateField = true)]
        [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public string? Cest { get; set; }

        [Display(Name = "Inativo", Description = "", AutoGenerateField = true)]
        public bool Inativo { get; set; }

        [Display(Name = "% IPI Vda.", Description = "", AutoGenerateField = true)]
        public decimal? IpiVenda { get; set; }

        [Display(Name = "Data Cadastro", Description = "", AutoGenerateField = true)]
        [IgnoreOnUpdate]
        public DateTime? DataCadastro { get; set; }

        [Display(Name = "Data Atualizacao", Description = "", AutoGenerateField = true)]
        [IgnoreOnInsert]
        public DateTime? DataAtualizacao { get; set; }

        [Display(Name = "Usuário Cadastro", Description = "", AutoGenerateField = true)]
        [IgnoreOnInsert]
        public string? UsuarioCadastro { get; set; }

        [Display(Name = "Usuário Atualizacao", Description = "", AutoGenerateField = true)]
        [IgnoreOnInsert]
        public string? UsuarioAtualizacao { get; set; }

        [Display(Name = "Redução BCICMS", Description = "", AutoGenerateField = false)]
        public double ReducaoBCICMS { get; set; }

        [Display(Name = "Id Plano Contábil", Description = "", AutoGenerateField = true)]
        [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public string? IdPlanoContabil { get; set; }

        [Display(Name = "Plano Contábil", Description = "", AutoGenerateField = true)]
        [MaxLength(150, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        public string? DescricaoPlanoContabil { get; set; }

        [Display(Name = "Id Plano Financeiro", Description = "", AutoGenerateField = true)]
        [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public string? IdPlanoFinanceiro { get; set; }

        [Display(Name = "Plano Financeiro", Description = "", AutoGenerateField = true)]
        [MaxLength(150, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        public string? DescricaoPlanoFinanceiro { get; set; }

        [Display(Name = "Tipo Item Fiscal", Description = "", AutoGenerateField = true)]
        [MaxLength(5, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public ETipoItemFiscal IdTipoItemFiscal { get; set; }

        [Display(Name = "Id Fabricante", Description = "", AutoGenerateField = true)]
        public int IdFabricante { get; set; }

        [Display(Name = "Fabricante", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        public string? DescricaoFabricante { get; set; }

        [Display(Name = "CST PIS", Description = "", AutoGenerateField = true)]
        public ECstPis? CstPIS { get; set; }

        [Display(Name = "CST COFINS", Description = "", AutoGenerateField = true)]
        public ECstCofins? CstCOFINS { get; set; }

        [Display(Name = "Controlar Estoque do Produto", Description = "", AutoGenerateField = true)]
        public bool ControleEstoque { get; set; }

        [Display(Name = "ID Segmento", Description = "", AutoGenerateField = true)]
        public int IdSegmento { get; set; }

        [Display(Name = "Segmento", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        public string? DescricaoSegmento { get; set; }

        [Display(Name = "Finalidade do Produto", Description = "", AutoGenerateField = true)]
        public ETipoFinalidadeProduto IdFinalidadeProduto { get; set; }

        [Display(Name = "Id Centro Custo", Description = "", AutoGenerateField = true)]
        public string? IdCentroCusto { get; set; }

        [Display(Name = "Centro de Custo", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        public string? DescricaoCentroCusto { get; set; }

        [Display(Name = "Valor", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        public decimal ValorVarejo { get; set; }

        [Display(Name = "Valor", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        public decimal ValorDistribuidora { get; set; }

        [Display(Name = "Desconto Distribuidora Padrão", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
        public decimal DescontoDistPadrao { get; set; }

        [Display(Name = "Desconto Varejo Padrão", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
        public decimal DescontoVarPadrao { get; set; }

        [Display(Name = "Desconto Distribuidora Gerência", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
        public decimal DescontoDistGerencia { get; set; }

        [Display(Name = "Desconto Varejo Gerência", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
        public decimal DescontoVarGerencia { get; set; }

        [Display(Name = "Desconto Distribuidora Regional", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
        public decimal DescontoDistRegional { get; set; }

        [Display(Name = "Desconto Varejo Regional", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
        public decimal DescontoVarRegional { get; set; }

        [Display(Name = "Desconto Distribuidora Diretoria", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
        public decimal DescontoDistDiretoria { get; set; }

        [Display(Name = "Desconto Varejo Diretoria", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
        public decimal DescontoVarDiretoria { get; set; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Padrão", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal ValorDescontoDistPadrao { get => ValorDistribuidora * (1 - DescontoDistPadrao); set => DescontoDistPadrao = ValorDistribuidora == 0 ? 0 : (ValorDistribuidora - value) / ValorDistribuidora; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Padrão", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal ValorDescontoVarPadrao { get => ValorVarejo * (1 - DescontoVarPadrao); set => DescontoVarPadrao = ValorVarejo == 0 ? 0 : (ValorVarejo - value) / ValorVarejo; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Gerência", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal ValorDescontoDistGerencia { get => ValorDistribuidora * (1 - DescontoDistGerencia); set => DescontoDistGerencia = ValorDistribuidora == 0 ? 0 : (ValorDistribuidora - value) / ValorDistribuidora; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Gerência", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal ValorDescontoVarGerencia { get => ValorVarejo * (1 - DescontoVarGerencia); set => DescontoVarGerencia = ValorVarejo == 0 ? 0 : (ValorVarejo - value) / ValorVarejo; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Regional", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal ValorDescontoDistRegional { get => ValorDistribuidora * ( 1 - DescontoDistRegional); set => DescontoDistRegional = ValorDistribuidora == 0 ? 0 : (ValorDistribuidora - value) / ValorDistribuidora; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Regional", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal ValorDescontoVarRegional { get => ValorVarejo * (1 - DescontoVarRegional); set => DescontoVarRegional = ValorVarejo == 0 ? 0 : (ValorVarejo - value) / ValorVarejo; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Diretoria", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal ValorDescontoDistDiretoria { get => ValorDistribuidora * (1 - DescontoDistDiretoria); set => DescontoDistDiretoria = ValorDistribuidora == 0 ? 0 : (ValorDistribuidora - value) / ValorDistribuidora; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Diretoria", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal ValorDescontoVarDiretoria { get => ValorVarejo * (1 - DescontoVarDiretoria); set => DescontoVarDiretoria = ValorVarejo == 0 ? 0 : (ValorVarejo - value) / ValorVarejo; }
    }
}
