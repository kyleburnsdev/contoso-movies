namespace ContosoMovies.Catalog.Interfaces.Model;

public interface IItemAggregate
{
    public string Id { get; set; }

    public int ItemId { get; set; }

    public int? BuyCount { get; set; }

    public int? ViewDetailsCount { get; set; }

    public int? AddToCartCount { get; set; }

    public int? VoteCount { get; set; }

    public IItem Item { get; set; }
}
