using RVEzyChallenge.Models;
using System.Data.Entity;

namespace RVEzyChallenge.DAL
{
    public class RVEzyContext : DbContext
    {
        // Especifique o nome do banco de dados como Vendas.
        public RVEzyContext()
            : base("RVEzy")
        {

        }
        // Cria um conjunto de tabelas para cada um dos itens de dados
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Calender> Calenders { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
