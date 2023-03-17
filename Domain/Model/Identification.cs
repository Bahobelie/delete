using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Identification
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string? Description { get; set; }

    public string IdNumber { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime? IssueDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Issuer { get; set; }

    public int Index { get; set; }

    public string? Remark { get; set; }

    public virtual Organization Reference1 { get; set; } = null!;

    public virtual Person Reference2 { get; set; } = null!;

    public virtual Article ReferenceNavigation { get; set; } = null!;
}
