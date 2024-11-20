using SGComserv.AbstractClass;
using SGComserv.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace SGComserv.Entitys;

[Table("tb_credenciais")]
public class CredenciaisEntity : BaseEntity<CredenciaisEntity>
{
    [Key, Display(Name = "Usuario", Description = "", AutoGenerateField = true)]
    public string NomeUsuario { get; set; } = string.Empty;

    [Display(Name = "Hash Senha", Description = "", AutoGenerateField = true)]
    [MaxLength(45, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
    [SwaggerSchema(ReadOnly = true), JsonIgnore] 
    public string HashSenha { get; set; } = string.Empty;

    [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
    public string Senha { get; set; } = string.Empty;

    public override string ToString()
    {
        return NomeUsuario.ToString();
    }
}
