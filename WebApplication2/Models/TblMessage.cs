using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class TblMessage
{
    public Guid MessageId { get; set; }

    public string? MessageContent { get; set; }

    public DateTime? MessageDate { get; set; }

    public virtual ICollection<TblTaiKhoanMessage> TblTaiKhoanMessages { get; set; } = new List<TblTaiKhoanMessage>();
}
