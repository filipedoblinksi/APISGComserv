using SGComserv.Entitys;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SGComserv.Attributes;
using SGComserv.Extensions;

namespace SGComserv.Models
{
    public class ProdutoPedidoViewModel : ProdutoPedidoEntity
    {
        public ProdutoPedidoViewModel()
        {
            this.Id = 0;
            this.IdPedido = 0;
            this.IdProduto = 0;
            this.Quantidade = 0;
            this.ValorUnitario = 0;
            this.QuantidadeDevolvida = 0;
            this.Observacoes = "";
        }

        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        public int Item { get; set; }

        [Display(Name = "Valor Tabela", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal? ValorUnitarioTabela { get; set; }

        [Display(Name = "Valor Total", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal ValorTotal { get { return Quantidade * ValorUnitario; } }

        [Display(Name = "Estoque", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        [DisplayFormat(DataFormatString = "N0", ApplyFormatInEditMode = true)]
        public decimal Estoque { get; set; }

        [Display(Name = "% Desc.", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
        public decimal PercDescontoCalculado
        {
            get
            {
                if (ValorUnitario < ValorUnitarioTabela) return (1 - ValorUnitario / ValorUnitarioTabela??0.ToDecimal());
                else return 0;
            }
            set
            {
                ValorUnitario = ValorUnitarioTabela??0.ToDecimal() - (ValorUnitarioTabela??0.ToDecimal() * value);
            }
        }

        [Display(Name = "ST", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal StCalculado { get; set; }

        [Display(Name = "IPI", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal IpiCalculado { get; set; }

        [Display(Name = "DIFAL", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
        public decimal DifalCalculado { get; set; }

        public virtual PrecoProdutoEntity? DadosPrecoProduto { get; set; }
    }
}


