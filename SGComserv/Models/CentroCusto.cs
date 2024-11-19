using SGComserv.Enums;

namespace SGComserv.Models;

public class CentroCusto {
    public string? Id { get; set; }
    public string? IdOriginal { get; set; }
    public string? Descricao { get; set; }
    public ENaturezaConta idNaturezaConta { get; set; }
}
