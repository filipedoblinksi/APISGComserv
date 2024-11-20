using System.ComponentModel;

namespace SGComserv.Enums;

public enum EModoFaturamento
{
    [Description("FATURAMENTO (NF-E)")]
    FATURAMENTO = 2,
    [Description("NFC-E")]
    NFCE = 8,
}
