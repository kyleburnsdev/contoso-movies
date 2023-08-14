namespace ContosoMovies.Catalog.Model;

/// <summary>
/// Placed orders.
/// </summary>
public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public bool? SmsoptIn { get; set; }

    public string? Smsstatus { get; set; }

    public string Email { get; set; } = null!;

    public string? ReceiptUrl { get; set; }

    public decimal? Total { get; set; }

    public string? PaymentTransactionId { get; set; }

    public bool? HasBeenShipped { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
