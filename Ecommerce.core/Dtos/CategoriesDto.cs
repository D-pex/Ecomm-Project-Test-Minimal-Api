namespace Ecommerce.core.Dtos;

public class CategoriesDto ( int categoryId , String categoryName )
{
    public int CategoryId { get; init; } = categoryId;
    public string CategoryName { get; init; } = categoryName;
}