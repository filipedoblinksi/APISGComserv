using System.ComponentModel.DataAnnotations;

namespace SGComserv.Entitys;

public class NivelSenhaEntity
{
    [Key]
    public string Nivel { get; set; } = string.Empty;
    public string? Modulo { get; set; }
    public string? SubModulo { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public DateTime? DataExclusao { get; set; }
}
