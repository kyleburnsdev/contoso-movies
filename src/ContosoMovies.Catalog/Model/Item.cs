namespace ContosoMovies.Catalog.Model;

/// <summary>
/// Movie items.
/// </summary>
public partial class Item 
{
    public int ItemId { get; set; }

    public int? VoteCount { get; set; }

    public string? ProductName { get; set; }

    public int? ImdbId { get; set; }

    public string? Description { get; set; }

    public string? ImagePath { get; set; }

    public string? ThumbnailPath { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? CategoryId { get; set; }

    public string? Category { get; set; }

    public decimal? Popularity { get; set; }

    public string? OriginalLanguage { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public decimal? VoteAverage { get; set; }

    public virtual ICollection<Cartitem> Cartitems { get; set; } = new List<Cartitem>();

    public virtual Category? CategoryNavigation { get; set; }

    public virtual ICollection<ItemAggregate> ItemAggregates { get; set; } = new List<ItemAggregate>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
