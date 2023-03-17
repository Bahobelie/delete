using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class CommunicationSource
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    /// <summary>
    /// Ca Be:Article (common),Device (common),Organization (common),Person (common)
    /// </summary>
    public string Reference { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Component { get; set; } = null!;

    public string CommunicateBy { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual Organization Reference1 { get; set; } = null!;

    public virtual Person Reference2 { get; set; } = null!;

    public virtual Article ReferenceNavigation { get; set; } = null!;
}
