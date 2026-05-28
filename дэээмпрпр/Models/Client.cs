using System;
using System.Collections.Generic;

namespace дэээмпрпр.Models;

public partial class Client
{
    public int Idclient { get; set; }

    public string Name { get; set; } = null!;

    public string Fio { get; set; } = null!;

    public string? Patronomik { get; set; }

    public int Role { get; set; }

    public string Email { get; set; } = null!;

    public long Phone { get; set; }
}
