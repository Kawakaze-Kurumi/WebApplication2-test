using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class GoodsType
{
    public string Code { get; set; } = null!;

    public string? GtName { get; set; }

    public string? Note { get; set; }
}
