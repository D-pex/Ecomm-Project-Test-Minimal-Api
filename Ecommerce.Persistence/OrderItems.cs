namespace Ecommerce.Persistence;

public sealed class OrderItems
{
   public int OrderitemId { get; set; }
   public int ProductId { get; set; }
   public int Quantity { get; set; }
   public int OrderId  { get; set; } 
}