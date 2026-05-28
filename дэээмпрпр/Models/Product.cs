using System;
using System.Collections.Generic;

namespace дэээмпрпр.Models;

public partial class Product
{
    public int Idproduct { get; set; }

    public string? Article { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public string Description { get; set; } = null!;

    public int ManufacturerId { get; set; }

    public int SuppliersId { get; set; }

    public decimal Price { get; set; }

    public int? Discount { get; set; }

    public int Count { get; set; }

    public int UnitId { get; set; }

    public string? Photo { get; set; }

    public virtual Categorium Category { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Supplier Suppliers { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
