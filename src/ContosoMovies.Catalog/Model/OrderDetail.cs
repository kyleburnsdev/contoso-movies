namespace ContosoMovies.Catalog.Model;

/// <summary>
/// All details related to placed orders.
/// </summary>
public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int OrderId { get; set; }

    public string Email { get; set; } = null!;

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Item? Product { get; set; }
}
