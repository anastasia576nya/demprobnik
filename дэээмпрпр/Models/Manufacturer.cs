using System;
using System.Collections.Generic;

namespace дэээмпрпр.Models;

public partial class Manufacturer
{
    public int Idmanufacturer { get; set; }

    public string ManufacturName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
