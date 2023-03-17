using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class DisplayOrder
{
    public int Id { get; set; }

    public string Component { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public int Index { get; set; }

    public string? Remark { get; set; }
}
