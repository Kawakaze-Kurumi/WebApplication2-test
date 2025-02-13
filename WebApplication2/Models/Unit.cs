using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Unit
{
    public string Code { get; set; } = null!;

    public string? UnitName { get; set; }

    public string? Note { get; set; }
}
