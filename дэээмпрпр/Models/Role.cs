using System;
using System.Collections.Generic;

namespace дэээмпрпр.Models;

public partial class Role
{
    public int Idrole { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
