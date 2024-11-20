using System.ComponentModel.DataAnnotations;

namespace SGComserv.Models
{
    public class ViewModel
    {

        public static string DISPLAYVALUE = "displayValue";
        [Display(Name = "Id", AutoGenerateField = true)]
        public object displayValue { get; set; }

        public static string VALUEMEMBER = "valueMember";
        [Display(Name = "Descrição", AutoGenerateField = true)]
        public string valueMember { get; set; }
    }
}
