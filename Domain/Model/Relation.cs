using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Relation
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string RelationType { get; set; } = null!;

    public string ReferenceObject { get; set; } = null!;

    public string ReferringObject { get; set; } = null!;

    public string? RelationLevel { get; set; }

    public string? Remark { get; set; }

    public virtual Organization ReferenceObject1 { get; set; } = null!;

    public virtual Person ReferenceObject2 { get; set; } = null!;

    public virtual Voucher ReferenceObject3 { get; set; } = null!;

    public virtual Article ReferenceObjectNavigation { get; set; } = null!;
}
