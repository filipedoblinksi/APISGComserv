namespace SGComserv.Entitys;

public class SetorEntregaEntity
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public bool Entrega_seg { get; set; }
    public bool Entrega_ter { get; set; }
    public bool Entrega_qua { get; set; }
    public bool Entrega_qui { get; set; }
    public bool Entrega_sex { get; set; }
    public bool Entrega_sab { get; set; }
    public bool Entrega_dom { get; set; }
    public string DiasEntrega
    {
        get
        {
            string dias = "";
            dias = dias + (Entrega_seg ? "1" : "");
            dias = dias + " " + (Entrega_ter ? "2" : "");
            dias = dias + " " + (Entrega_qua ? "3" : "");
            dias = dias + " " + (Entrega_qui ? "4" : "");
            dias = dias + " " + (Entrega_sex ? "5" : "");
            dias = dias + " " + (Entrega_sab ? "6" : "");
            dias = dias + " " + (Entrega_dom ? "0" : "");
            return dias;
        }
    }
}
