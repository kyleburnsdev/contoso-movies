namespace ContosoMovies.Catalog.Model;

/// <summary>
/// User clickstream events, such as browsing and adding items to a cart.
/// </summary>
public partial class Event
{
    public string Id { get; set; } = null!;

    public string? Event1 { get; set; }

    public int? UserId { get; set; }

    public int? ItemId { get; set; }

    public int? OrderId { get; set; }

    public int? ContentId { get; set; }

    public string? SessionId { get; set; }

    public DateTime? Created { get; set; }

    public string? Region { get; set; }

    public virtual User? User { get; set; }
}
