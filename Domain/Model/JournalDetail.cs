using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class JournalDetail
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Voucher { get; set; } = null!;

    public string Account { get; set; } = null!;

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string? Remark { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
