using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class ChatMessage
{
    public int MessageId { get; set; }

    public string? Username { get; set; }

    public string? MessageText { get; set; }

    public DateTime? Timestamp { get; set; }

    public virtual TblTaiKhoan? UsernameNavigation { get; set; }
}
