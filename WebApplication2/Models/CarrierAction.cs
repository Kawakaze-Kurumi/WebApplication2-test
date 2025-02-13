﻿using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class CarrierAction
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? PersonInCharge { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? LccFee { get; set; }

    public string? Note { get; set; }

    public virtual Carrier? CodeNavigation { get; set; }
}
