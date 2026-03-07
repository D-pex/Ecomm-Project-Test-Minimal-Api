namespace Ecommerce.Persistence;

public sealed  class Products
{
    public int ProductId { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty; 
    public decimal Price  { get; set; } 
    public int stock { get; set; }
    public int CategoryId { get; set; }
}