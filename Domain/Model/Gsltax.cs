using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Gsltax
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    /// <summary>
    /// Can Be:Article (common),Organization (common),Person (common),Tax (common)
    /// </summary>
    public string Reference { get; set; } = null!;

    public int Tax { get; set; }

    public string? Remark { get; set; }

    public virtual Organization Reference1 { get; set; } = null!;

    public virtual Person Reference2 { get; set; } = null!;

    public virtual Article ReferenceNavigation { get; set; } = null!;
}
