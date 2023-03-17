using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Beginning
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    /// <summary>
    /// Can Be:Article (common),Device (common),Organization (common),Person (common)
    /// </summary>
    public string Reference { get; set; } = null!;

    public string Period { get; set; } = null!;

    public decimal Value { get; set; }

    public string? Type { get; set; }

    public bool IsProvisional { get; set; }

    public string? Remark { get; set; }

    public virtual Organization Reference1 { get; set; } = null!;

    public virtual Person Reference2 { get; set; } = null!;

    public virtual Article ReferenceNavigation { get; set; } = null!;
}
