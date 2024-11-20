using SGComserv.AbstractClass;
using SGComserv.Attributes;
using SGComserv.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGComserv.Entitys;

[Table("tb_produtospedido")]
public class ProdutoPedidoEntity : BaseEntity<ProdutoPedidoEntity>
{
    public ProdutoPedidoEntity()
    {
        Id = 0;
        IdPedido = 0;
        IdProduto = 0;
        Quantidade = 0;
        ValorUnitario = 0;
        QuantidadeDevolvida = 0;
        Observacoes = string.Empty;
        ValorOutros = 0;
        PercDescontoLiberado = 0;
    }

    [Key, AutoIncrement, IgnoreOnInsert, Required]
    public int Id { get; set; }

    [Display(Name = "Id Pedido")]
    public int IdPedido { get; set; }

    [Display(Name = "Id Produto")]
    [MaxLength(45)]
    public int IdProduto { get; set; }

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public virtual ProdutoEntity DadosProduto { get; set; } = new ProdutoEntity();

    [Display(Name = "Qtde.")]
    [DisplayFormat(DataFormatString = "N0", ApplyFormatInEditMode = true)]
    public decimal Quantidade { get; set; }

    [Display(Name = "Valor Unit.")]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal ValorUnitario { get; set; }

    [Display(Name = "Qtde. Dev.")]
    [DisplayFormat(DataFormatString = "N0", ApplyFormatInEditMode = true)]
    public decimal QuantidadeDevolvida { get; set; }

    [Display(Name = "Observações")]
    public string Observacoes { get; set; }

    [Display(Name = "Valor Outros")]
    [DisplayFormat(DataFormatString = "N2", ApplyFormatInEditMode = true)]
    public decimal ValorOutros { get; set; }

    [Display(Name = "Desconto Liberado")]
    public bool DescontoLiberado { get; set; }

    [Display(Name = "% Desconto Liberado")]
    [DisplayFormat(DataFormatString = "p1", ApplyFormatInEditMode = true)]
    public decimal? PercDescontoLiberado { get; set; }

    [Display(Name = "idUsuarioDescontoLiberado")]
    public int? IdUsuarioDescontoLiberado{ get; set; } 

    [Display(Name = "dataDescontoLiberado")]
    public DateTime? DataDescontoLiberado { get; set; }
}
