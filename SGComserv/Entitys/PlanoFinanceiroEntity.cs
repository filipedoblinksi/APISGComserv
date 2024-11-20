using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SGComserv.AbstractClass;
using SGComserv.Attributes;
using SGComserv.Enums;

namespace SGComserv.Entitys
{
    [Table("tb_planofinanceiro")]
    public class PlanoFinanceiroEntity : BaseEntity<PlanoFinanceiroEntity>
    {
        public PlanoFinanceiroEntity()
        {
            IdPlanoFinanceiro = string.Empty;
            IdPlanoFinanceiroOriginal = string.Empty;
            Descricao = string.Empty;
            Desabilitado = false;
            IdTipoDocumento = 0;
            IdTipoGasto = 0;
            Imposto = false;
            IdPlanoContabil = string.Empty;
            EmpresaPermitida = string.Empty;
            IdNaturezaConta = ENaturezaConta.Sintetica;
        }

        [Key, Display(Name = "Plano Financeiro", Description = "", AutoGenerateField = true)]
        [MaxLength(60, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        [KeyOriginal(nameof(IdPlanoFinanceiroOriginal))]
        public string IdPlanoFinanceiro { get; set; }

        [Display(Name = "Plano Financeiro", Description = "", AutoGenerateField = true)]
        [NotMapped, IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        public string IdPlanoFinanceiroOriginal { get; set; }

        [Display(Name = "Descrição Financeira", Description = "", AutoGenerateField = true)]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} dígitos.")]
        public string Descricao { get; set; }

        [Display(Name = "Desabilitado", Description = "", AutoGenerateField = true)]
        public bool Desabilitado { get; set; }

        [Display(Name = "Tipo de Pagamento", Description = "", AutoGenerateField = true)]
        public int? IdTipoDocumento { get; set; }

        [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        public TipoDocumentoFinanceiroEntity? DadoTipoDocumentoFinanceiro { get; set; }

        [Display(Name = "Tipo de Gasto", Description = "", AutoGenerateField = true)]
        public int? IdTipoGasto { get; set; }

        [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        public TipoGastoEntity? DadoTipoGasto { get; set; }

        [Display(Name = "Imposto", Description = "", AutoGenerateField = true)]
        public bool Imposto { get; set; }

        [Display(Name = "Plano Contábil", Description = "", AutoGenerateField = true)]
        [MaxLength(50, ErrorMessage = "Este campo deve conter no máximo 50 dígitos.")]
        public string? IdPlanoContabil { get; set; }

        [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        public PlanoContabilEntity? DadosPlanoContabil { get; set; }

        [Display(Name = "Empresas permitidas", Description = "Empresas permitidas para visualização desta conta", AutoGenerateField = true)]
        public string? EmpresaPermitida { get; set; }

        [Display(Name = "Natureza Conta", Description = "", AutoGenerateField = true)]
        public ENaturezaConta IdNaturezaConta { get; set; }

        [Display(Name = "CC", Description = "Obrigatório Centro de Custo", AutoGenerateField = true)]
        public bool ObrigatorioCentroCusto { get; set; }

        [Display(Name = "CV", Description = "Obrigatório Classe de Valor", AutoGenerateField = true)]
        public bool ObrigatorioClasseDeValor { get; set; }

        [IgnoreOnInsert, IgnoreOnUpdate, IgnoreOnHistoric]
        public ICollection<RegraPlanoFinanceiroCCEntity>? DadosRegraPlanoFinanceiroCC { get; set; }

        public override string ToString()
        {
            return $"{IdPlanoFinanceiro} - {Descricao}";
        }

        public void OnAfterLoad()
        {
            IdPlanoFinanceiroOriginal = IdPlanoFinanceiro;
        }
    }
}
