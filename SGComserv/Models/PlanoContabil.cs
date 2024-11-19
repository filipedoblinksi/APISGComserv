using SGComserv.Enums;

namespace SGComserv.Models;

public class PlanoContabil {
    public string idPlanoContabil { get; set; }
    public string idPlanoContabilOriginal { get; set; }
    public string descricao { get; set; }
    public bool desabilitado { get; set; }
    public int contaReduzida { get; set; }
    public string empresaPermitida { get; set; }
    public ENaturezaConta idNaturezaConta { get; set; }
}
