namespace InventoryAPIEntityF.Models;

public class Product{
    public Guid ProducID{get;set;}
    public string ProductName{get;set;}
    public double Price{get;set;}
    public Category Category{get;set;}
}