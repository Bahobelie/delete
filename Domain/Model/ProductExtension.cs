using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class ProductExtension
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Article { get; set; } = null!;

    public string? Brand { get; set; }

    public string? Generic { get; set; }

    public string Model { get; set; } = null!;

    public string? Size { get; set; }

    public string? Color { get; set; }

    public string? Country { get; set; }

    public string? Manufacturer { get; set; }

    public string? Remark { get; set; }

    public virtual Article ArticleNavigation { get; set; } = null!;
}
