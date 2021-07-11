using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyCoinAPI.Areas.carteira.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Sigla")]
        [Column("Sigla")]
        public string Sigla { get; set; }
    }
}