namespace ContosoMovies.Catalog.Model;

/// <summary>
/// Movies added to a user&apos;s cart.
/// </summary>
public partial class Cartitem
{
    public string CartItemId { get; set; } = null!;

    public string? CartId { get; set; }

    public int? ItemId { get; set; }

    public int? Quantity { get; set; }

    public DateTime? DateCreated { get; set; }

    public virtual Item? Item { get; set; }

}
