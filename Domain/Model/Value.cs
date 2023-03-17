using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Value
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Article { get; set; } = null!;

    public string? Description { get; set; }

    public string? Component { get; set; }

    public string? Reference { get; set; }

    public decimal PriceValue { get; set; }

    public bool IsDefault { get; set; }

    public string Currency { get; set; } = null!;

    public byte Priority { get; set; }

    public string? Remark { get; set; }

    public virtual Article ArticleNavigation { get; set; } = null!;
}
