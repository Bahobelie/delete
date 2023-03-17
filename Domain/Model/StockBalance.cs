using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class StockBalance
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Article { get; set; } = null!;

    public string Store { get; set; } = null!;

    public string? Batch { get; set; }

    public decimal Quantity { get; set; }

    public string Type { get; set; } = null!;

    public string? Period { get; set; }

    public string? Remark { get; set; }

    public virtual Article ArticleNavigation { get; set; } = null!;

    public virtual OrganizationUnitDefinition StoreNavigation { get; set; } = null!;
}
