using System;
using System.Collections.Generic;

namespace дэээмпрпр.Models;

public partial class Order
{
    public int Idorder { get; set; }

    public string Article { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? Patronomic { get; set; }

    public int StatusId { get; set; }

    public int AddresId { get; set; }

    public DateOnly DataOrder { get; set; }

    public DateOnly? DataDeliviry { get; set; }

    public string OrderStructure { get; set; } = null!;

    public virtual Addre Addres { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
