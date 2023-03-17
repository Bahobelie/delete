using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class BankAccountDetail
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    /// <summary>
    /// Can Be: BankAccountDetail (common),Person (common)
    /// </summary>
    public string Reference { get; set; } = null!;

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public string? Category { get; set; }

    public string Bank { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual Person ReferenceNavigation { get; set; } = null!;
}
