using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Address
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    /// <summary>
    /// Can Be:Organization (common),Person (common),Store (common)
    /// </summary>
    public string Reference { get; set; } = null!;

    public string Preference { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual Person Reference1 { get; set; } = null!;

    public virtual Organization ReferenceNavigation { get; set; } = null!;
}
