namespace ContosoMovies.Catalog.Model;

/// <summary>
/// Movie categories.
/// </summary>
public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public string? Products { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
