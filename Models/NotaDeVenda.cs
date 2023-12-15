using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vitorhugo.Models
{
    public class NotaDeVenda
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "ID PAGAMENTO")]
        public int IdPagamento { get; set; }
        [Display(Name = "ID TRANSPORTADORA")]
        public int IdTransportadora { get; set; }
        [Display(Name = "ID VENDEDOR")]
        public int IdVendedor { get; set; }
        [Display(Name = "ID CLIENTE")]
        public int IdCliente { get; set; }
        [Display(Name = "DATA")]
        public DateTime Data { get; set; }
        [Display(Name = "TIPO")]
        public bool Tipo { get; set; }
        public virtual ICollection<Item> ?Items {get; set;}

    }
}