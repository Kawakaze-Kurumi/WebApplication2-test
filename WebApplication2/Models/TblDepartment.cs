using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class TblDepartment
{
    public string DepartmentId { get; set; } = null!;

    public string? DepName { get; set; }

    public string? Other { get; set; }

    public string? Note { get; set; }

    public string? ComId { get; set; }

    public virtual TblCom? Com { get; set; }

    public virtual ICollection<TblStaff> TblStaffs { get; set; } = new List<TblStaff>();
}
