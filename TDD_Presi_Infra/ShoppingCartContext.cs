using Microsoft.EntityFrameworkCore;
using TDD_Presentation_domain;

namespace TDD_Presi_Infra
{
    public class ShoppingCartContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ShoppingCart> ShoppingCarts => Set<ShoppingCart>();

        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options) : base(options)
        {
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {       
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<ShoppingCart>().HasKey(s => s.Id);
        }
    }
}
