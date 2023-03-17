using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class LineItem
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Voucher { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal? UnitAmt { get; set; }

    public decimal Quantity { get; set; }

    public string? Uom { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal TaxableAmount { get; set; }

    public int? Tax { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? CalculatedCost { get; set; }

    public string? Remark { get; set; }

    public virtual Article ArticleNavigation { get; set; } = null!;

    public virtual ICollection<LineItemReference> LineItemReferenceLineItemNavigations { get; } = new List<LineItemReference>();

    public virtual ICollection<LineItemReference> LineItemReferenceReferencedNavigations { get; } = new List<LineItemReference>();

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
