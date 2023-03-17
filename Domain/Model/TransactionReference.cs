using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class TransactionReference
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Referening { get; set; } = null!;

    public string Referenced { get; set; } = null!;

    public decimal? Value { get; set; }

    public string? RelationType { get; set; }

    public string? Remark { get; set; }

    public virtual Voucher ReferencedNavigation { get; set; } = null!;

    public virtual Voucher RefereningNavigation { get; set; } = null!;
}
