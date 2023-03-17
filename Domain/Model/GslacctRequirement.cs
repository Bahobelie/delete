using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class GslacctRequirement
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string ContAcct { get; set; } = null!;

    public int GslTypeList { get; set; }

    public bool IsMandatory { get; set; }

    public bool RestrictSelection { get; set; }

    public string? Remark { get; set; }
}
