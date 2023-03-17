using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Career
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Person { get; set; } = null!;

    public int Index { get; set; }

    public string Organization { get; set; } = null!;

    public string Level { get; set; } = null!;

    public string Field { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal Duration { get; set; }

    public string? Award { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }
}
