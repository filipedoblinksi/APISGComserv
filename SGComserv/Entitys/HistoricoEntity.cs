using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SGComserv.AbstractClass;
using SGComserv.Attributes;

namespace SGComserv.Entitys
{
    [Table("tb_historico")]
    public class HistoricoEntity : BaseEntity<HistoricoEntity>
    {
        [Key, AutoIncrement]
        [Display(Name = "Id", Description = "", AutoGenerateField = false)]
        public int id { get; set; }

        [Display(Name = "Tabela", Description = "", AutoGenerateField = false)]
        public string tabela { get; set; } = string.Empty;

        [Display(Name = "Id", Description = "", AutoGenerateField = true)]
        public string idObjeto { get; set; } = string.Empty;

        [Display(Name = "Nome Campo", Description = "", AutoGenerateField = true)]
        public string nomeCampo { get; set; } = string.Empty;

        [Display(Name = "Descrição do Campo", Description = "", AutoGenerateField = true)]
        public string descricaoCampo { get; set; } = string.Empty;

        [Display(Name = "Valor Antigo", Description = "", AutoGenerateField = true)]
        public string valorAntigo { get; set; } = string.Empty;

        [Display(Name = "Novo Valor", Description = "", AutoGenerateField = true)]
        public string novoValor { get; set; } = string.Empty;

        [Display(Name = "Usuário", Description = "", AutoGenerateField = true)]
        public string nomeUsuarioAlteracao { get; set; } = string.Empty;

        [Display(Name = "Data Alteração", Description = "", AutoGenerateField = true)]
        [DisplayFormat(DataFormatString = @"dd\/MM\/yyyy hh:mm:ss", ApplyFormatInEditMode = true)]
        public DateTime dataAlteracao { get; set; } = DateTime.Now;
    }
}
