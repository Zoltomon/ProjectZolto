using System;
using System.Collections.Generic;

namespace AutoZolto.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? StatusId { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<LogHistory> LogHistories { get; set; } = new List<LogHistory>();

    public virtual ICollection<PersonalDatum> PersonalData { get; set; } = new List<PersonalDatum>();

    public virtual Role? Role { get; set; }

    public virtual Status? Status { get; set; }
}
