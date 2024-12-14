using Demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Product> Products { get; set; } = null!;

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(builder =>
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2);
        });

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Apple", Price = 1.99m },
            new Product { Id = 2, Name = "Banana", Price = 0.99m },
            new Product { Id = 3, Name = "Cherry", Price = 2.99m }
        );
    }
}
