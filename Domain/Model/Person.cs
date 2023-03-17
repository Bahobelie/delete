﻿using System;
using System.Collections.Generic;

namespace cnet_db_op.Domain.Model;

public partial class Person
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public int Type { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Nationality { get; set; }

    public DateTime? Dob { get; set; }

    public string? Title { get; set; }

    public string? MaritalStatus { get; set; }

    public string Gender { get; set; } = null!;

    public string? Religion { get; set; }

    public string? Preference { get; set; }

    public bool IsActive { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<AccountMap> AccountMaps { get; } = new List<AccountMap>();

    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual ICollection<BankAccountDetail> BankAccountDetails { get; } = new List<BankAccountDetail>();

    public virtual ICollection<Beginning> Beginnings { get; } = new List<Beginning>();

    public virtual ICollection<CommunicationSource> CommunicationSources { get; } = new List<CommunicationSource>();

    public virtual ICollection<Gsltax> Gsltaxes { get; } = new List<Gsltax>();

    public virtual ICollection<Identification> Identifications { get; } = new List<Identification>();

    public virtual ICollection<IndustryInvolved> IndustryInvolveds { get; } = new List<IndustryInvolved>();

    public virtual ICollection<NonCashTransaction> NonCashTransactions { get; } = new List<NonCashTransaction>();

    public virtual ICollection<ObjectState> ObjectStates { get; } = new List<ObjectState>();

    public virtual ICollection<OptionalCode> OptionalCodes { get; } = new List<OptionalCode>();

    public virtual ICollection<Relation> Relations { get; } = new List<Relation>();

    public virtual ICollection<TransactionLimit> TransactionLimits { get; } = new List<TransactionLimit>();

    public virtual ICollection<Voucher> Vouchers { get; } = new List<Voucher>();
}
