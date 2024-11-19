using System.ComponentModel;

namespace SGComserv.Enums;

public enum ESubTabela {
    [Description("INDEFINIDA")]
    Indefinida = 0,
    [Description("VAREJO")]
    Varejo = 1,
    [Description("ATACADO")]
    Atacado = 2,
    [Description("PROMOCIONAL")]
    Promocional = 3,
}
