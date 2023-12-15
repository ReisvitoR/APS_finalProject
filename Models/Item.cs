using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vitorhugo.Models
{
    public class Item
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "ID PRODUTO")]
        public int IdProduto { get; set; }
        [Display(Name = "PERCENTUAL")]
        public int Percentual { get; set; }
        [Display(Name = "QUANTIDADE")]
        public int Quantidade { get; set; }
        public virtual ICollection<Produto> ?Produtos {get; set;} 
        public List<NotaDeVenda>? Notavendas {get;set;}
    }
}