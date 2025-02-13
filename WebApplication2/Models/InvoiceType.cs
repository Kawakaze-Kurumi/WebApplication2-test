using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class InvoiceType
{
    public string Code { get; set; } = null!;

    public string? NameType { get; set; }
}
