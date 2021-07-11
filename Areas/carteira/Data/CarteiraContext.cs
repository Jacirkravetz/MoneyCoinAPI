using Microsoft.EntityFrameworkCore;
using MoneyCoinAPI.Areas.carteira.Models;

namespace MoneyCoinAPI.Areas.carteira.Data
{
    public class CarteiraContext : DbContext
    {

        public CarteiraContext(DbContextOptions<CarteiraContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Corretora> Corretora { get; set; }
        public DbSet<Papel> Papel { get; set; }
        public DbSet<TipoOperacao> TipoOperacao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Operacao> Operacao { get; set; }
    }
}