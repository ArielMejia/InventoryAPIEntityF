
namespace InventoryAPIEntityF.Models;

public class Category{
    public string CategoryID{get;set;}
    public string CategoryName{get;set;} 
    public ICollection<Product> Products{set;get;}
    
}