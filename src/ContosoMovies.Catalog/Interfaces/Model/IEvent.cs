namespace ContosoMovies.Catalog.Interfaces.Model;

public interface IEvent
{
    public string Id { get; set; }

    public string? Event1 { get; set; }

    public int? UserId { get; set; }

    public int? ItemId { get; set; }

    public int? OrderId { get; set; }

    public int? ContentId { get; set; }

    public string? SessionId { get; set; }

    public DateTime? Created { get; set; }

    public string? Region { get; set; }

    public IUser? User { get; set; }
}
