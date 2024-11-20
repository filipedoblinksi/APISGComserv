using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SGComserv.AbstractClass;
using SGComserv.Attributes;

namespace SGComserv.Entitys
{
    [Table("tb_precoproduto")]
    public class PrecoProdutoEntity : BaseEntity<PrecoProdutoEntity>
    {
        [IgnoreOnInsert, IgnoreOnUpdate]
        [Required, Display(Name = "ID Único", Description = "", AutoGenerateField = true)]
        public string KeyFieldName { get => $"{IdSubTabela}|{IdProduto}"; }

        [Key, Required, Display(Name = "ID SubTabela", Description = "", AutoGenerateField = true)]
        public int IdSubTabela { get; set; }

        [IgnoreOnInsert, IgnoreOnUpdate]
        public virtual SubTabelaVendaEntity? DadosSubTabela { get; set; }

        [Key, Required, Display(Name = "ID Produto", Description = "", AutoGenerateField = true)]
        public int IdProduto { get; set; } = 0;

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Custo", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        public decimal Custo { get; set; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Base Calculo do Custo", Description = "", AutoGenerateField = false)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        public decimal BaseCalculoCusto { get; set; }

        [Display(Name = "Valor", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        public decimal ValorVarejo { get; set; }

        [Display(Name = "Valor", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        public decimal ValorAtacado { get; set; }

        [Display(Name = "Valor", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        public decimal ValorPromocional { get; set; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Descrição", Description = "", AutoGenerateField = true)]
        public string DescricaoProduto { get; set; } = string.Empty;

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Margem", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "P2", ApplyFormatInEditMode = true)]
        public decimal MargemVarejo { get => Custo == 0 ? 0 : (ValorVarejo - Custo) / Custo; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Margem", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "P2", ApplyFormatInEditMode = true)]
        public decimal MargemAtacado { get => Custo == 0 ? 0 : Custo != 0 ? (ValorAtacado - Custo) / Custo : 0; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Margem", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "P2", ApplyFormatInEditMode = true)]
        public decimal MargemPromocional { get => Custo == 0 ? 0 : Custo != 0 ? (ValorPromocional - Custo) / Custo : 0; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Lucro", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "P2", ApplyFormatInEditMode = true)]
        public decimal LucroVarejo { get => Custo == 0 ? 0 : ValorVarejo != 0 ? (ValorVarejo - Custo) / ValorVarejo : 0; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Lucro", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "P2", ApplyFormatInEditMode = true)]
        public decimal LucroAtacado { get => Custo == 0 ? 0 : ValorAtacado != 0 ? (ValorAtacado - Custo) / ValorAtacado : 0; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Lucro", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "P2", ApplyFormatInEditMode = true)]
        public decimal LucroPromocional { get => Custo == 0 ? 0 : ValorPromocional != 0 ? (ValorPromocional - Custo) / ValorPromocional : 0; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Valor Ativa", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        public decimal ValorVarejoAtivo { get; set; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Valor Ativa", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        public decimal ValorAtacadoAtivo { get; set; }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate]
        [Display(Name = "Valor Ativa", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = "C2", ApplyFormatInEditMode = true)]
        public decimal ValorPromocionalAtivo { get; set; }
    }
}

