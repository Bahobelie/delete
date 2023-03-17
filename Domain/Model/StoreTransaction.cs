using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class StoreTransaction
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Voucher { get; set; } = null!;

    public string? Source { get; set; }

    public string? Destination { get; set; }

    public bool HasEffet { get; set; }

    public string? Remark { get; set; }

    public virtual OrganizationUnitDefinition? DestinationNavigation { get; set; }

    public virtual OrganizationUnitDefinition? SourceNavigation { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
