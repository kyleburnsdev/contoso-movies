namespace ContosoMovies.Catalog.Interfaces.Model;

public interface IOrderDetail
{
    public int OrderDetailId { get; set; }

    public int OrderId { get; set; }

    public string Email { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public IOrder Order { get; set; }

    public IItem? Product { get; set; }
}