using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyCoinAPI.Areas.carteira.Models
{
    [Table("Operacao")]
    public class Operacao
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }
        public Usuario usuario { get; set; }
        public Corretora corretora { get; set; }
        public Papel papel { get; set; }
        public TipoOperacao tipoOperacao { get; set; }

        [Display(Name = "dataOperacao")]
        [Column("dataOperacao")]
        public DateTime dataOperacao { get; set; }

        [Display(Name = "valorUnitario")]
        [Column("valorUnitario")]
        public decimal valorUnitario { get; set; }

        [Display(Name = "quantidade")]
        [Column("quantidade")]
        public decimal quantidade { get; set; }

        [Display(Name = "valorTotal")]
        [Column("valorTotal")]
        public decimal valorTotal { get; set; }

    }
}