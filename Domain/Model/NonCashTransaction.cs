using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class NonCashTransaction
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Voucher { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public bool IsIncoming { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string? PaymentProcesser { get; set; }

    public int Index { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string Number { get; set; } = null!;

    public decimal? Rate { get; set; }

    public decimal Amount { get; set; }

    public bool Executed { get; set; }

    public string? CurrencyCode { get; set; }

    public string? DepositRef { get; set; }

    public string? Remark { get; set; }

    public virtual OrganizationUnit Consignee1 { get; set; } = null!;

    public virtual Person Consignee2 { get; set; } = null!;

    public virtual Organization ConsigneeNavigation { get; set; } = null!;

    public virtual Organization? PaymentProcesserNavigation { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
