namespace Ecommerce.core.Dtos;

public  sealed class OrderItemsDto ( int OrderitemId  , int OrderId , int ProductId , int Quantity )
{
    public int OrderitemId { get; init; } =  OrderitemId;
    public int OrderId { get; init; } =  OrderId;
    public int ProductId { get; init; } =  ProductId; 
    public int Quantity { get; init; } =   Quantity;
}