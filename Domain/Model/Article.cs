using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Article
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public int GslType { get; set; }

    public string Name { get; set; } = null!;

    public string Preference { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<AccountMap> AccountMaps { get; } = new List<AccountMap>();

    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    public virtual ICollection<Beginning> Beginnings { get; } = new List<Beginning>();

    public virtual ICollection<CommunicationSource> CommunicationSources { get; } = new List<CommunicationSource>();

    public virtual ICollection<Gsltax> Gsltaxes { get; } = new List<Gsltax>();

    public virtual ICollection<Identification> Identifications { get; } = new List<Identification>();

    public virtual ICollection<IndustryInvolved> IndustryInvolveds { get; } = new List<IndustryInvolved>();

    public virtual ICollection<LineItem> LineItems { get; } = new List<LineItem>();

    public virtual ICollection<ObjectState> ObjectStates { get; } = new List<ObjectState>();

    public virtual ICollection<OptionalCode> OptionalCodes { get; } = new List<OptionalCode>();

    public virtual ICollection<ProductExtension> ProductExtensions { get; } = new List<ProductExtension>();

    public virtual ICollection<Relation> Relations { get; } = new List<Relation>();

    public virtual ICollection<SerialDefinition> SerialDefinitions { get; } = new List<SerialDefinition>();

    public virtual ICollection<StockBalance> StockBalances { get; } = new List<StockBalance>();

    public virtual ICollection<StockLevel> StockLevels { get; } = new List<StockLevel>();

    public virtual ICollection<TransactionLimit> TransactionLimits { get; } = new List<TransactionLimit>();

    public virtual ICollection<Value> Values { get; } = new List<Value>();
}
