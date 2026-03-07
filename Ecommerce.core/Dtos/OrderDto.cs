namespace Ecommerce.core.Dtos;

public sealed class OrderDto (int OrderId , int UserId , DateOnly OrderDate)
{
    public int OrderId { get; init; } = OrderId;
    public int UserId { get; init; } =  UserId;
    public DateOnly OrderDate { get; init; } = OrderDate; 
}