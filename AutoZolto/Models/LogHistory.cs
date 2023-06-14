using System;
using System.Collections.Generic;

namespace AutoZolto.Models;

public partial class LogHistory
{
    public int Id { get; set; }

    public DateTime? DateAuto { get; set; }

    public DateTime? DateExitt { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
