using SGComserv.AbstractClass;
using SGComserv.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SGComserv.Entitys;

[Table("tb_usuario")]
public class UsuarioEntity : BaseEntity<UsuarioEntity>
{
    [Key, Display(Name = "Id", Description = "", AutoGenerateField = true)]
    public int Id { get; set; }

    [Display(Name = "Nome", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string Nome { get; set; }

    [Display(Name = "ID Vendedor", Description = "", AutoGenerateField = true)]
    public int IdFornecedor { get; set; }

    [Display(Name = "Inativo", Description = "", AutoGenerateField = true)]
    public bool Inativo { get; set; }

    [Display(Name = "Somente Acessso Remoto", Description = "", AutoGenerateField = true)]
    public bool AcessoRemoto { get; set; }

    [Display(Name = "ipPublico", Description = "", AutoGenerateField = true)]
    public string? IpPublico { get; set; }

    [Display(Name = "niveisSenha", Description = "", AutoGenerateField = true)]
    public List<NivelSenhaEntity> NiveisSenha { get; set; }

    [Display(Name = "% Desconto Venda", Description = "", AutoGenerateField = true)]
    public decimal PercentualDescontoVenda { get; set; }

    [Display(Name = "Tema", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Tema { get; set; }

    [Display(Name = "Paleta", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? Paleta { get; set; }

    [Display(Name = "", Description = "", AutoGenerateField = true)]
    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public bool Selecionado { get; set; }

    [Display(Name = "Empesas Ultimo Login", Description = "", AutoGenerateField = false)]
    [MaxLength(130, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    public string? IdsEmpresasSelecionadas { get; set; }

    public UsuarioEntity()
    {
        this.Id = 0;
        this.Nome = string.Empty;
        this.IdFornecedor = 0;
        this.Inativo = false;
        this.AcessoRemoto = false;
        this.IpPublico = string.Empty;
        NiveisSenha = new List<NivelSenhaEntity>();
    }
    public override string ToString()
    {
        return Nome.ToString();
    }
}
