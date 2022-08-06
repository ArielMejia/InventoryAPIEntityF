
using InventoryAPIEntityF.Models;
using Microsoft.EntityFrameworkCore;

public class InventoryContext : DbContext
{
    public DbSet<Category> Categories{get;set;}
    public DbSet<Product> Products{get;set;}
}