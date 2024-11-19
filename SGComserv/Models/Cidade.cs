namespace SGComserv.Models;

public class Cidade {
    public int Id { get; set; }
    public string? Cuf { get; set; }
    public string? Suf { get; set; }
    public string? Cmunicipio { get; set; }
    public string? Dmunicipio { get; set; }
    public DateTime? DataAtualizacao { get; set; }
    public DateTime? DataExclusao { get; set; }
}
