using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Activity
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Component { get; set; }

    /// <summary>
    /// Can Be:Article (common),Organization (common),Person (common),User (common),Voucher (common)
    /// </summary>
    public string Reference { get; set; } = null!;

    public string ActivitiyDefinition { get; set; } = null!;

    public DateTime StartTimStamp { get; set; }

    public DateTime? EndTimStamp { get; set; }

    public string? OrganizationUnitDef { get; set; }

    public string? Device { get; set; }

    public string? User { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Date { get; set; }

    public string? Remark { get; set; }

    public virtual OrganizationUnitDefinition? OrganizationUnitDefNavigation { get; set; }

    public virtual Organization Reference1 { get; set; } = null!;

    public virtual Person Reference2 { get; set; } = null!;

    public virtual Voucher Reference3 { get; set; } = null!;

    public virtual Article ReferenceNavigation { get; set; } = null!;
}
