using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vitorhugo.Models
{
    public class TipoDePagamento
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "NOME DO COBRADO")]
        public string ?NomeDoCobrado { get; set; }
        [Display(Name = "INFORMACOES ADICIONAIS")]
        public string ?InformacoesAdicionais { get; set; }
    }
}