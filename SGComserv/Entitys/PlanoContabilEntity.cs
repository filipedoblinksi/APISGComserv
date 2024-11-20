using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SGComserv.AbstractClass;
using SGComserv.Attributes;
using SGComserv.Enums;

namespace SGComserv.Entitys
{
    [Table("tb_planocontabil")]
    public class PlanoContabilEntity : BaseEntity<PlanoContabilEntity>
    {
        public PlanoContabilEntity()
        {
            IdPlanoContabil = string.Empty;
            IdPlanoContabilOriginal = string.Empty;
            Descricao = string.Empty;
            Desabilitado = false;
            idNaturezaConta = 0;
            EmpresaPermitida = string.Empty;
        }

        [Key, Display(Name = "Código Contábil", Description = "", AutoGenerateField = true)]
        [MaxLength(60, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        [KeyOriginal(nameof(IdPlanoContabilOriginal))]
        public string IdPlanoContabil { get; set; }

        [Display(Name = "Codigo Contabil Original", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        public string IdPlanoContabilOriginal { get; set; }

        [Display(Name = "Descrição Contábil", Description = "", AutoGenerateField = true)]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public string Descricao { get; set; }

        [Display(Name = "Desabilitado", Description = "", AutoGenerateField = true)]
        public bool Desabilitado { get; set; }

        [Display(Name = "CR", Description = "", AutoGenerateField = true)]
        public int ContaReduzida { get; set; }

        [Display(Name = "Empresas permitidas", Description = "Empresas permitidas para visualização desta conta", AutoGenerateField = true)]
        public string EmpresaPermitida { get; set; }

        [Display(Name = "Natureza da Conta", Description = "", AutoGenerateField = true)]
        public ENaturezaConta idNaturezaConta { get; set; }

        public override string ToString()
        {
            return $"{IdPlanoContabil} - {Descricao}";
        }

        public void OnAfterLoad()
        {
            IdPlanoContabilOriginal = IdPlanoContabil;
        }
    }
}
