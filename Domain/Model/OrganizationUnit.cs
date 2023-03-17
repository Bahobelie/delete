using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class OrganizationUnit
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Component { get; set; }

    public string Reference { get; set; } = null!;

    public string OrganizationUnitDefinition { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    public virtual OrganizationUnitDefinition OrganizationUnitDefinitionNavigation { get; set; } = null!;

    public virtual Organization ReferenceNavigation { get; set; } = null!;
}
