using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class SerialDefinition
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Article { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsMandantory { get; set; }

    public string? Remark { get; set; }

    public virtual Article ArticleNavigation { get; set; } = null!;
}
