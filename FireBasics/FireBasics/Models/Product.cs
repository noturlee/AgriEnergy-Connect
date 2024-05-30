using System;
using System.Collections.Generic;

namespace FireBasics.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public string? ImageUrl { get; set; }

    public double? Price { get; set; }

    public int? Quantity { get; set; }

    public string? Availability { get; set; }

    public DateOnly? ProductionDate { get; set; }

    public int? FarmerId { get; set; }

    public int? CategoryId { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Category { get; set; }

    public virtual User? Farmer { get; set; }
}
