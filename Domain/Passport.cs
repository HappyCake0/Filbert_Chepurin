using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public partial class Passport
{
    public long Id { get; set; }

    [Column("r_person_id")]
    public long? RPersonId { get; set; }

    public string? Series { get; set; }

    public string? Number { get; set; }

    public Person Person { get; set; }
}
