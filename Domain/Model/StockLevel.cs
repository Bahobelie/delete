using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class StockLevel
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Article { get; set; } = null!;

    public string Store { get; set; } = null!;

    public decimal? MinLevel { get; set; }

    public decimal? MaxLevel { get; set; }

    public decimal? LeadTime { get; set; }

    public decimal? EconomicOrderQty { get; set; }

    public string? Remark { get; set; }

    public virtual Article ArticleNavigation { get; set; } = null!;

    public virtual OrganizationUnitDefinition StoreNavigation { get; set; } = null!;
}
