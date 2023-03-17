using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class CartTransaction
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Cart { get; set; } = null!;

    public string? Component { get; set; }

    public string Reference { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Value { get; set; }

    public string? Remark { get; set; }

    public virtual Voucher ReferenceNavigation { get; set; } = null!;
}
