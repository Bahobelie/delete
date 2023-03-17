using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class AccountMap
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public string Account { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual Organization Reference1 { get; set; } = null!;

    public virtual Person Reference2 { get; set; } = null!;

    public virtual Article ReferenceNavigation { get; set; } = null!;
}
