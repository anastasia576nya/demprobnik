using System;
using System.Collections.Generic;

namespace дэээмпрпр.Models;

public partial class Unit
{
    public int Idunit { get; set; }

    public string UnitName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
