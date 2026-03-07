namespace Ecommerce.core.Dtos;

public sealed class UserDto (int Id , string FirstName, string LastName, string Email, string PhoneNumber  )
{
    public int Id { get; init; } = Id;
    public string FirstName { get; init; } = FirstName;
    public string LastName { get; init; } = LastName;
    public string Email { get; init; } = Email;
    public string PhoneNumber { get; init; } = PhoneNumber;
}