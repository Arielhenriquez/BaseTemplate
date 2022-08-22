using BaseTemplate.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseTemplate.Data.Context
{
    public class SuperMarketDbContext : DbContext
    {
        public SuperMarketDbContext(DbContextOptions<SuperMarketDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperMarkets>()
                .HasOne(p => p.Products)
                .WithMany(s => s.SuperMarkets)
                .HasForeignKey(pr => pr.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SuperMarkets>()
              .HasOne(b => b.Brands)
              .WithMany(s => s.SuperMarkets)
              .HasForeignKey(pr => pr.BrandId);

            modelBuilder.Entity<ShoppingList>()
              .HasKey(p => new { p.ProductId, p.SuperMarketId });

            modelBuilder.Entity<ShoppingList>()
            .HasOne(u => u.Products)
            .WithMany(sl => sl.ShoppingLists)
            .HasForeignKey(u => u.ProductId);

            modelBuilder.Entity<ShoppingList>()
              .HasOne(u => u.SuperMarkets)
              .WithMany(sl => sl.ShoppingLists)
              .HasForeignKey(u => u.SuperMarketId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<SuperMarkets> SuperMarkets { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}
