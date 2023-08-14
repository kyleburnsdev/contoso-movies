namespace ContosoMovies.Catalog.Interfaces.Model;

public interface ICartItem
{
    public string CartItemId { get; set; }

    public string? CartId { get; set; }

    public int? ItemId { get; set; }

    public int? Quantity { get; set; }

    public DateTime? DateCreated { get; set; }

    public IItem? Item { get; set; }
}
