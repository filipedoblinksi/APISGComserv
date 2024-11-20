using System.ComponentModel;

namespace SGComserv.Enums;

public enum ETipoItemFiscal
{
    [Description("MERCADORIA PARA REVENDA")]
    MercadoriaRevenda = 0,
    [Description("MATÉRIA-PRIMA")]
    MateriaPrima = 1,
    [Description("EMBALAGEM")]
    Embalagem = 2,
    [Description("PRODUTO EM PROCESSO")]
    ProdutoEmProcesso = 3,
    [Description("PRODUTO ACABADO")]
    ProdutoAcabado = 4,
    [Description("SUBPRODUTO")]
    SubProduto = 5,
    [Description("PRODUTO INTERMEDIÁRIO")]
    ProdutoIntermediario = 6,
    [Description("MATERIAL DE USO E CONSUMO")]
    MaterialUsoConsumo = 7,
    [Description("ATIVO IMOBILIZADO")]
    AtivoImobilizado = 8,
    [Description("SERVIÇOS")]
    Servicos = 9,
    [Description("OUTROS INSUMOS")]
    OutrosInsumos = 10,
    [Description("OUTRAS")]
    Outras = 99,
}
