using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Gslnote
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string GslReference { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string? Remark { get; set; }
}
