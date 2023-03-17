using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class OptionalCode
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Article { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string CodeValue { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual Organization Article1 { get; set; } = null!;

    public virtual Person Article2 { get; set; } = null!;

    public virtual Article ArticleNavigation { get; set; } = null!;
}
