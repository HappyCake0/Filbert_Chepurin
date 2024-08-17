using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public partial class Debt
{
    public long Id { get; set; }

    [Column("r_person_id")]
    public long? RPersonId { get; set; }

    [Column("contract_number")]
    public string? ContractNumber { get; set; }

    [Column("contract_dt")]
    public string? ContractDt { get; set; }

    [Column("debt_sum")]
    public string? DebtSum { get; set; }

    public Person Person { get; set; }
}
