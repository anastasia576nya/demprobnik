using System;
using System.Collections.Generic;

namespace дэээмпрпр.Models;

public partial class Categorium
{
    public int Idcategoria { get; set; }

    public string CategoriaName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
