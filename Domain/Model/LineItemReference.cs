using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class LineItemReference
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string LineItem { get; set; } = null!;

    public string Referenced { get; set; } = null!;

    public int ReferingVouDfn { get; set; }

    public decimal Value { get; set; }

    public string? Remark { get; set; }

    public virtual LineItem LineItemNavigation { get; set; } = null!;

    public virtual LineItem ReferencedNavigation { get; set; } = null!;
}
