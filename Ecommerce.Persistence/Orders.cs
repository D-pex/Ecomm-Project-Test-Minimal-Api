namespace Ecommerce.Persistence;

public  sealed class Orders
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
}