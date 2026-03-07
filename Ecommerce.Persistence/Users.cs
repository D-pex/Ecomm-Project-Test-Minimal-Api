namespace Ecommerce.Persistence;

public sealed  class Users
{
    public int ID { get; set; }
    public string FirstName  { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
    public DateTime CreatedAt  { get; set; }
}