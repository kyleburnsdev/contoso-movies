namespace ContosoMovies.Catalog.Interfaces.Model;

public interface IUser
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public int? CategoryId { get; set; }

    public string? Personality { get; set; }

    public ICategory? Category { get; set; }

    public ICollection<IEvent> Events { get; set; }
}