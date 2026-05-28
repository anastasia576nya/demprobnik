using System;
using System.Collections.Generic;

namespace дэээмпрпр.Models;

public partial class Supplier
{
    public int Idsuppliers { get; set; }

    public string SuppliersName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
