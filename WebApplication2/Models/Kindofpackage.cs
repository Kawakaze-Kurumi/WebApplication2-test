using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Kindofpackage
{
    public string Code { get; set; } = null!;

    public string? PackageName { get; set; }

    public string? PackagesDescription { get; set; }
}
