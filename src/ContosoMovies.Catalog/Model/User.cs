namespace ContosoMovies.Catalog.Model;

/// <summary>
/// All user accounts.
/// </summary>
public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public int? CategoryId { get; set; }

    public string? Personality { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
