using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyCoinAPI.Areas.carteira.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "IdFirebase")]
        [Column("IdFirebase")]
        public string IdFirebase { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }

        public ICollection<Operacao> Operacoes { get; set; }
    }
}