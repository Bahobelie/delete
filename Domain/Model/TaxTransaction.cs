using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class TaxTransaction
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Voucher { get; set; } = null!;

    public int TaxType { get; set; }

    public decimal TaxableAmount { get; set; }

    public decimal TaxAmount { get; set; }

    public string? Remark { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
