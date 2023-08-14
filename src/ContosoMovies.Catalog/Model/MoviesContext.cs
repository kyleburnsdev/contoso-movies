using Microsoft.EntityFrameworkCore;

namespace ContosoMovies.Catalog.Model;

public partial class MoviesContext : DbContext
{
    public MoviesContext()
    {
    }

    public MoviesContext(DbContextOptions<MoviesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cartitem> Cartitems { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemAggregate> ItemAggregates { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cartitem>(entity =>
        {
            entity.ToTable("Cartitem", tb => tb.HasComment("Movies added to a user's cart."));

            entity.Property(e => e.CartItemId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CartId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.HasOne(d => d.Item).WithMany(p => p.Cartitems)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_Cartitem_Item");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category", tb => tb.HasComment("Movie categories."));

            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Products)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("Event", tb => tb.HasComment("User clickstream events, such as browsing and adding items to a cart."));

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.ContentId).HasColumnName("contentId");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Event1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("event");
            entity.Property(e => e.ItemId).HasColumnName("itemId");
            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("region");
            entity.Property(e => e.SessionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sessionId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Events)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Event_User");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.ToTable("Item", tb => tb.HasComment("Movie items."));

            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ImagePath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OriginalLanguage)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Popularity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReleaseDate).HasColumnType("date");
            entity.Property(e => e.ThumbnailPath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VoteAverage).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Item_Category");
        });

        modelBuilder.Entity<ItemAggregate>(entity =>
        {
            entity.ToTable("ItemAggregate", tb => tb.HasComment("Aggregates, such as buy count, view details count, add item to cart count, and vote count. 1:1 relationship with Items. A batch process updates these counts, which is an internal process we cannot share at this time."));

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemAggregates)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemAggregate_Item");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("Placed orders."));

            entity.Property(e => e.Address)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(160)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(160)
                .IsUnicode(false);
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentTransactionId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(24)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SmsoptIn).HasColumnName("SMSOptIn");
            entity.Property(e => e.Smsstatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SMSStatus");
            entity.Property(e => e.State)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId).HasName("PK_OrderDetails_1");

            entity.ToTable(tb => tb.HasComment("All details related to placed orders."));

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_Orders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_OrderDetails_Item");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User", tb => tb.HasComment("All user accounts."));

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Personality)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Category).WithMany(p => p.Users)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_User_Category");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
