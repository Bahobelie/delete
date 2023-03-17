using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class IndustryInvolved
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public int Index { get; set; }

    public string Reference { get; set; } = null!;

    public string Industy { get; set; } = null!;

    public string? Involvment { get; set; }

    public string? Remark { get; set; }

    public virtual Organization Reference1 { get; set; } = null!;

    public virtual Person Reference2 { get; set; } = null!;

    public virtual Article ReferenceNavigation { get; set; } = null!;
}
