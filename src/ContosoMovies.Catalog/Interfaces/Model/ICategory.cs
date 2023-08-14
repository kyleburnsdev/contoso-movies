
namespace ContosoMovies.Catalog.Interfaces.Model;
public interface ICategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public string? Products { get; set; }

    public ICollection<IItem> Items { get; set; }

    public ICollection<IUser> Users { get; set; }
}