using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class TblTaiKhoanMessage
{
    public int Id { get; set; }

    public Guid MessageId { get; set; }

    public string Username { get; set; } = null!;

    public bool? IsRead { get; set; }

    public virtual TblMessage Message { get; set; } = null!;

    public virtual TblTaiKhoan UsernameNavigation { get; set; } = null!;
}
