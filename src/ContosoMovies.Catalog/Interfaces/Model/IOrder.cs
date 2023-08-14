namespace ContosoMovies.Catalog.Interfaces.Model;

public interface IOrder
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }

    public string Phone { get; set; }

    public bool? SmsoptIn { get; set; }

    public string? Smsstatus { get; set; }

    public string Email { get; set; }

    public string? ReceiptUrl { get; set; }

    public decimal? Total { get; set; }

    public string? PaymentTransactionId { get; set; }

    public bool? HasBeenShipped { get; set; }

    public ICollection<IOrderDetail> OrderDetails { get; set; }
}
