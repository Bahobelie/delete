using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Voucher
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int VoucherDefinition { get; set; }

    public string? Component { get; set; }

    public string? Consignee { get; set; }

    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int Date { get; set; }

    public bool IsVoid { get; set; }

    public decimal GrandTotal { get; set; }

    public string? Period { get; set; }

    public string? LastObjectState { get; set; }

    public string? LastActivity { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    public virtual ICollection<CartTransaction> CartTransactions { get; } = new List<CartTransaction>();

    public virtual ICollection<ClosedRelation> ClosedRelations { get; } = new List<ClosedRelation>();

    public virtual Person? Consignee1 { get; set; }

    public virtual Organization? ConsigneeNavigation { get; set; }

    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();

    public virtual ICollection<LineItem> LineItems { get; } = new List<LineItem>();

    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    public virtual ICollection<ObjectState> ObjectStates { get; } = new List<ObjectState>();

    public virtual ICollection<Relation> Relations { get; } = new List<Relation>();

    public virtual ICollection<StoreTransaction> StoreTransactions { get; } = new List<StoreTransaction>();

    public virtual ICollection<TaxTransaction> TaxTransactions { get; } = new List<TaxTransaction>();

    public virtual ICollection<TransactionReference> TransactionReferenceReferencedNavigations { get; } = new List<TransactionReference>();

    public virtual ICollection<TransactionReference> TransactionReferenceRefereningNavigations { get; } = new List<TransactionReference>();

    public virtual ICollection<VoucherExtensionTransaction> VoucherExtensionTransactions { get; } = new List<VoucherExtensionTransaction>();

    public virtual ICollection<VoucherNote> VoucherNotes { get; } = new List<VoucherNote>();

    public virtual ICollection<VoucherTerm> VoucherTerms { get; } = new List<VoucherTerm>();

    public virtual ICollection<VoucherValue> VoucherValues { get; } = new List<VoucherValue>();
}
