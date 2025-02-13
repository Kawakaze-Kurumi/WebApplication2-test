using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class TblTuttJob
{
    public string Stt { get; set; } = null!;

    public string? SoTutt { get; set; }

    public string? Hbl { get; set; }

    public virtual TblHbl? HblNavigation { get; set; }

    public virtual TblTutt? SoTuttNavigation { get; set; }
}
