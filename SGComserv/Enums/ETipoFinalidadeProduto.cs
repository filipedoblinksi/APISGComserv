using System.ComponentModel;

namespace SGComserv.Enums;

public enum ETipoFinalidadeProduto
{
    [Description("INDEFINIDO")]
    DefaultValue = 0,
    [Description("VENDA")]
    Venda = 1,
    [Description("COMPRA")]
    Compra = 2,
    [Description("VENDA/COMPRA")]
    Ambos = 3,
}
