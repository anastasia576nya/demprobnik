using System;
using System.Collections.Generic;

namespace дэээмпрпр.Models;

public partial class Addre
{
    public int Idaddres { get; set; }

    public string Addres { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
