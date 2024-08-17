using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public partial class Person
{
    public long Id { get; set; }

    public string F { get; set; } = null!;

    public string I { get; set; } = null!;

    public string O { get; set; } = null!;

    [Column("birth_date")]
    public string BirthDate { get; set; } = null!;

    public Passport Passport { get; set; }

    public ICollection<Debt> Debts { get; set; }
}
