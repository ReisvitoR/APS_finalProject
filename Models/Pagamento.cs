using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vitorhugo.Models
{
    public class Pagamento
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "DATA LIMITE")]
        public DateTime DataLimite { get; set; }
        [Display(Name = "VALOR")]
        public double Valor { get; set; }
        [Display(Name = "PAGO")]
        public bool Pago { get; set; }
    }
}