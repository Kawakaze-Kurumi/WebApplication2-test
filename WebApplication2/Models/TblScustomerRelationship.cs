using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class TblScustomerRelationship
{
    public int Id { get; set; }

    public string? ScustumerId { get; set; }

    public DateTime? CusDate { get; set; }

    public string? CusSatus { get; set; }

    public string? Scheme { get; set; }

    public string? Other { get; set; }

    public virtual TblScustomer? Scustumer { get; set; }
}
