using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class ClosedRelation
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public DateTime TimeStamp { get; set; }

    public string Voucher { get; set; } = null!;

    public int ReferredVoucherDefn { get; set; }

    public int ReferringVoucherDefn { get; set; }

    public string? Remark { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
