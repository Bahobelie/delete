using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class VoucherValue
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Voucher { get; set; } = null!;

    public decimal? Discount { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? AdditionalCharge { get; set; }

    public string? Remark { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
