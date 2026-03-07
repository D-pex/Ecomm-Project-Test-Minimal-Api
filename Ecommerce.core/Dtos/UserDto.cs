namespace Ecommerce.core.Dtos;

public sealed class UserDto (int Id , string FirstName, string LastName, string Email, string PhoneNumber  )
{
    public int Id { get; set; } = Id;
    public string FirstName { get; set; } = FirstName;
    public string LastName { get; set; } = LastName;
    public string Email { get; set; } = Email;
    public string PhoneNumber { get; set; } = PhoneNumber;
}