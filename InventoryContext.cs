
using InventoryAPIEntityF.Models;
using Microsoft.EntityFrameworkCore;

public class InventoryContext : DbContext
{
    public DbSet<Category> Categories{get;set;}
    public DbSet<Product> Products{get;set;}
    public InventoryContext(DbContextOptions<InventoryContext> options) : base(options){}
    protected override void OnModelCreating(ModelBuilder modelbuilder){
        modelbuilder.Entity<Category>(Category =>
        {
            Category.ToTable("Category");
            Category.HasKey(p => p.CategoryID);
            Category.Property(p => p.CategoryName).IsRequired().HasMaxLength(60);
        });

        modelbuilder.Entity<Product>(Product => 
        {
            Product.ToTable("Product");
            Product.HasKey(p => p.ProducID);
            Product.Property(p => p.ProductName).IsRequired().HasMaxLength(60);
            Product.Property(p => p.Price).IsRequired();
            Product.HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey( p => p.CategoryID);
        });
    }
}