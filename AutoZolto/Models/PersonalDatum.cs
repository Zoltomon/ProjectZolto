using System;
using System.Collections.Generic;

namespace AutoZolto.Models;

public partial class PersonalDatum
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Patronomic { get; set; }

    public string? SeriesPassport { get; set; }

    public string? NumberPassport { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
