namespace ContosoMovies.Catalog.Model;

/// <summary>
/// Aggregates, such as buy count, view details count, add item to cart count, and vote count. 1:1 relationship with Items. A batch process updates these counts, which is an internal process we cannot share at this time.
/// </summary>
public partial class ItemAggregate
{
    public string Id { get; set; } = null!;

    public int ItemId { get; set; }

    public int? BuyCount { get; set; }

    public int? ViewDetailsCount { get; set; }

    public int? AddToCartCount { get; set; }

    public int? VoteCount { get; set; }

    public virtual Item Item { get; set; } = null!;
}
