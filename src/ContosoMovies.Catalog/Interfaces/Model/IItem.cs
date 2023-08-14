using System.Collections.Generic;

namespace ContosoMovies.Catalog.Interfaces.Model;

public interface IItem
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

    public ICollection<ICartItem> Cartitems { get; set; }

    public ICategory? CategoryNavigation { get; set; }

    public ICollection<IItemAggregate> ItemAggregates { get; set; }

    public ICollection<IOrderDetail> OrderDetails { get; set; }
}