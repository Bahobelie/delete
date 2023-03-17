using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class OrganizationUnitDefinition
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? ParentId { get; set; }

    public string? Specialization { get; set; }

    public string? Abbriviation { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    public virtual ICollection<OrganizationUnit> OrganizationUnits { get; } = new List<OrganizationUnit>();

    public virtual ICollection<StockBalance> StockBalances { get; } = new List<StockBalance>();

    public virtual ICollection<StockLevel> StockLevels { get; } = new List<StockLevel>();

    public virtual ICollection<StoreTransaction> StoreTransactionDestinationNavigations { get; } = new List<StoreTransaction>();

    public virtual ICollection<StoreTransaction> StoreTransactionSourceNavigations { get; } = new List<StoreTransaction>();
}
