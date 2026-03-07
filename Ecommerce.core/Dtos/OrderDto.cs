namespace Ecommerce.core.Dtos;

public sealed class OrderDto (int OrderId , int UserId , DateOnly OrderDate)
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public DateOnly OrderDate { get; set; }
}