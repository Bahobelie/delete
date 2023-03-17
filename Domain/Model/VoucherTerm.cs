using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class VoucherTerm
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Voucher { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string? Value { get; set; }

    public string? Remark { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
