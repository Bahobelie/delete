using System;
using System.Collections.Generic;
using cnet_db_op.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace cnet_db_op.Domain.Data;

public partial class Cnet2016Context : DbContext
{
    public Cnet2016Context()
    {
    }

    public Cnet2016Context(DbContextOptions<Cnet2016Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountMap> AccountMaps { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<BankAccountDetail> BankAccountDetails { get; set; }

    public virtual DbSet<Beginning> Beginnings { get; set; }

    public virtual DbSet<Career> Careers { get; set; }

    public virtual DbSet<CartTransaction> CartTransactions { get; set; }

    public virtual DbSet<ClosedRelation> ClosedRelations { get; set; }

    public virtual DbSet<CommunicationSource> CommunicationSources { get; set; }

    public virtual DbSet<DisplayOrder> DisplayOrders { get; set; }

    public virtual DbSet<GslacctRequirement> GslacctRequirements { get; set; }

    public virtual DbSet<Gslnote> Gslnotes { get; set; }

    public virtual DbSet<Gsltax> Gsltaxes { get; set; }

    public virtual DbSet<Identification> Identifications { get; set; }

    public virtual DbSet<IndustryInvolved> IndustryInvolveds { get; set; }

    public virtual DbSet<JournalDetail> JournalDetails { get; set; }

    public virtual DbSet<LineItem> LineItems { get; set; }

    public virtual DbSet<LineItemReference> LineItemReferences { get; set; }

    public virtual DbSet<NonCashTransaction> NonCashTransactions { get; set; }

    public virtual DbSet<ObjectState> ObjectStates { get; set; }

    public virtual DbSet<OptionalCode> OptionalCodes { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<OrganizationUnit> OrganizationUnits { get; set; }

    public virtual DbSet<OrganizationUnitDefinition> OrganizationUnitDefinitions { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<ProductExtension> ProductExtensions { get; set; }

    public virtual DbSet<Relation> Relations { get; set; }

    public virtual DbSet<SerialDefinition> SerialDefinitions { get; set; }

    public virtual DbSet<StockBalance> StockBalances { get; set; }

    public virtual DbSet<StockLevel> StockLevels { get; set; }

    public virtual DbSet<StoreTransaction> StoreTransactions { get; set; }

    public virtual DbSet<TaxTransaction> TaxTransactions { get; set; }

    public virtual DbSet<TransactionLimit> TransactionLimits { get; set; }

    public virtual DbSet<TransactionReference> TransactionReferences { get; set; }

    public virtual DbSet<Value> Values { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VoucherExtensionTransaction> VoucherExtensionTransactions { get; set; }

    public virtual DbSet<VoucherNote> VoucherNotes { get; set; }

    public virtual DbSet<VoucherTerm> VoucherTerms { get; set; }

    public virtual DbSet<VoucherValue> VoucherValues { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-6V38F10\\SQLEXPRESS;Initial Catalog=CNET2016;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountMap>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("AccountMap", "common");

            entity.HasIndex(e => e.Code, "IX_AccountMap").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Account)
                .HasMaxLength(26)
                .HasColumnName("account");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.AccountMaps)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountMap_PersonReferene");

            entity.HasOne(d => d.Reference1).WithMany(p => p.AccountMaps)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountMap_OrganizationReference");

            entity.HasOne(d => d.Reference2).WithMany(p => p.AccountMaps)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountMap_ArticleReference");
        });

        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_Activity_1");

            entity.ToTable("Activity", "common");

            entity.HasIndex(e => e.Code, "IX_Activity").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.ActivitiyDefinition)
                .HasMaxLength(26)
                .HasColumnName("activitiyDefinition");
            entity.Property(e => e.Component)
                .HasMaxLength(26)
                .HasColumnName("component");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Device)
                .HasMaxLength(26)
                .HasColumnName("device");
            entity.Property(e => e.EndTimStamp)
                .HasColumnType("datetime")
                .HasColumnName("endTimStamp");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.OrganizationUnitDef)
                .HasMaxLength(26)
                .HasColumnName("organizationUnitDef");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasComment("Can Be:Article (common),Organization (common),Person (common),User (common),Voucher (common)")
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.StartTimStamp)
                .HasColumnType("datetime")
                .HasColumnName("startTimStamp");
            entity.Property(e => e.User)
                .HasMaxLength(26)
                .HasColumnName("user");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.OrganizationUnitDefNavigation).WithMany(p => p.Activities)
                .HasForeignKey(d => d.OrganizationUnitDef)
                .HasConstraintName("FK_Activity_OrganizationUnitDefinition");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.Activities)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_Article");

            entity.HasOne(d => d.Reference1).WithMany(p => p.Activities)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_Organization");

            entity.HasOne(d => d.Reference2).WithMany(p => p.Activities)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_Person");

            entity.HasOne(d => d.Reference3).WithMany(p => p.Activities)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Activity_Voucher");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_Address_1");

            entity.ToTable("Address", "common", tb => tb.HasTrigger("addressDeleteTrigger"));

            entity.HasIndex(e => e.Code, "IX_Address").IsUnique();

            entity.HasIndex(e => new { e.Preference, e.Reference }, "_dta_index_Address_5_608317527__K4_K3_5");

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Preference)
                .HasMaxLength(26)
                .HasColumnName("preference");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasComment("Can Be:Organization (common),Person (common),Store (common)")
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Organization");

            entity.HasOne(d => d.Reference1).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Person");
        });

        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Article", "common");

            entity.HasIndex(e => e.GslType, "GSL_Type_Index");

            entity.HasIndex(e => e.Code, "IX_Article").IsUnique();

            entity.HasIndex(e => e.Code, "_dta_index_Article_5_1139743363__K2_4");

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.GslType).HasColumnName("gslType");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Preference)
                .HasMaxLength(26)
                .HasColumnName("preference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Uom)
                .HasMaxLength(15)
                .HasColumnName("uom");
        });

        modelBuilder.Entity<BankAccountDetail>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("BankAccountDetail", "common");

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(40)
                .HasColumnName("accountNo");
            entity.Property(e => e.Bank)
                .HasMaxLength(26)
                .HasColumnName("bank");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasComment("Can Be: BankAccountDetail (common),Person (common)")
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.BankAccountDetails)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccountDetail_OrganizationUnit");
        });

        modelBuilder.Entity<Beginning>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Beginning", "common");

            entity.HasIndex(e => e.Code, "IX_Beginning").IsUnique();

            entity.HasIndex(e => e.Reference, "_dta_index_Beginning_5_1574661053__K3_5");

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IsProvisional).HasColumnName("isProvisional");
            entity.Property(e => e.Period)
                .HasMaxLength(26)
                .HasColumnName("period");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasComment("Can Be:Article (common),Device (common),Organization (common),Person (common)")
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasColumnType("money")
                .HasColumnName("value");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.Beginnings)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beginning_Article");

            entity.HasOne(d => d.Reference1).WithMany(p => p.Beginnings)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beginning_Organization");

            entity.HasOne(d => d.Reference2).WithMany(p => p.Beginnings)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beginning_Person");
        });

        modelBuilder.Entity<Career>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Career", "hrms");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Award).HasColumnName("award");
            entity.Property(e => e.Duration)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("duration");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.Field)
                .HasMaxLength(50)
                .HasColumnName("field");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .HasColumnName("level");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Organization)
                .HasMaxLength(50)
                .HasColumnName("organization");
            entity.Property(e => e.Person)
                .HasMaxLength(50)
                .HasColumnName("person");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<CartTransaction>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_CartTransaction_1");

            entity.ToTable("CartTransaction", "common");

            entity.HasIndex(e => e.Code, "IX_CartTransaction").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Cart)
                .HasMaxLength(26)
                .HasColumnName("cart");
            entity.Property(e => e.Component)
                .HasMaxLength(26)
                .HasColumnName("component");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Value)
                .HasColumnType("money")
                .HasColumnName("value");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.CartTransactions)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartTransaction_Voucher");
        });

        modelBuilder.Entity<ClosedRelation>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ClosedRelation", "common");

            entity.HasIndex(e => e.Code, "IX_ClosedRelation").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ReferredVoucherDefn).HasColumnName("referredVoucherDefn");
            entity.Property(e => e.ReferringVoucherDefn).HasColumnName("referringVoucherDefn");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("timeStamp");
            entity.Property(e => e.Voucher)
                .HasMaxLength(26)
                .HasColumnName("voucher");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.ClosedRelations)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClosedRelation_ClosedRelation");
        });

        modelBuilder.Entity<CommunicationSource>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CommunicationSource", "common");

            entity.HasIndex(e => e.Code, "IX_CommunicationSource").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.CommunicateBy)
                .HasMaxLength(26)
                .HasColumnName("communicateBy");
            entity.Property(e => e.Component)
                .HasMaxLength(26)
                .HasColumnName("component");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasComment("Ca Be:Article (common),Device (common),Organization (common),Person (common)")
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(26)
                .HasColumnName("type");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.CommunicationSources)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunicationSource_Article");

            entity.HasOne(d => d.Reference1).WithMany(p => p.CommunicationSources)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunicationSource_Organization");

            entity.HasOne(d => d.Reference2).WithMany(p => p.CommunicationSources)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunicationSource_Person");
        });

        modelBuilder.Entity<DisplayOrder>(entity =>
        {
            entity.ToTable("DisplayOrder", "pos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Component).HasMaxLength(26);
            entity.Property(e => e.Reference).HasMaxLength(26);
            entity.Property(e => e.Remark).HasMaxLength(50);
        });

        modelBuilder.Entity<GslacctRequirement>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("GSLAcctRequirement", "common");

            entity.HasIndex(e => e.GslTypeList, "GSL_type_list_Index");

            entity.HasIndex(e => e.Code, "IX_GSLAcctRequirement").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.ContAcct)
                .HasMaxLength(26)
                .HasColumnName("contAcct");
            entity.Property(e => e.GslTypeList).HasColumnName("gslTypeList");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IsMandatory).HasColumnName("isMandatory");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.RestrictSelection).HasColumnName("restrictSelection");
        });

        modelBuilder.Entity<Gslnote>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("GSLNote", "common");

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.GslReference)
                .HasMaxLength(26)
                .HasColumnName("gslReference");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<Gsltax>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("GSLTax", "common");

            entity.HasIndex(e => e.Code, "IX_GSLTax").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasComment("Can Be:Article (common),Organization (common),Person (common),Tax (common)")
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Tax).HasColumnName("tax");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.Gsltaxes)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLTax_Article");

            entity.HasOne(d => d.Reference1).WithMany(p => p.Gsltaxes)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLTax_Organization");

            entity.HasOne(d => d.Reference2).WithMany(p => p.Gsltaxes)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GSLTax_Person");
        });

        modelBuilder.Entity<Identification>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Identification", "common");

            entity.HasIndex(e => e.Code, "IX_Identification").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiryDate");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IdNumber).HasColumnName("idNumber");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IssueDate)
                .HasColumnType("datetime")
                .HasColumnName("issueDate");
            entity.Property(e => e.Issuer)
                .HasMaxLength(25)
                .HasColumnName("issuer");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(26)
                .HasColumnName("type");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.Identifications)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Identification_Article");

            entity.HasOne(d => d.Reference1).WithMany(p => p.Identifications)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Identification_Organization");

            entity.HasOne(d => d.Reference2).WithMany(p => p.Identifications)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Identification_Person");
        });

        modelBuilder.Entity<IndustryInvolved>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("IndustryInvolved", "common");

            entity.HasIndex(e => e.Code, "IX_IndustryInvolved").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Industy)
                .HasMaxLength(26)
                .HasColumnName("industy");
            entity.Property(e => e.Involvment)
                .HasMaxLength(26)
                .HasColumnName("involvment");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.IndustryInvolveds)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndustryInvolved_Article");

            entity.HasOne(d => d.Reference1).WithMany(p => p.IndustryInvolveds)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndustryInvolved_Organization");

            entity.HasOne(d => d.Reference2).WithMany(p => p.IndustryInvolveds)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndustryInvolved_Person");
        });

        modelBuilder.Entity<JournalDetail>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_JournalDetail_1");

            entity.ToTable("JournalDetail", "common", tb => tb.HasTrigger("Prevent_Update_JournalDetail_Trigger"));

            entity.HasIndex(e => e.Code, "IX_JournalDetail").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Account)
                .HasMaxLength(26)
                .HasColumnName("account");
            entity.Property(e => e.Credit)
                .HasColumnType("money")
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasColumnType("money")
                .HasColumnName("debit");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Voucher)
                .HasMaxLength(26)
                .HasColumnName("voucher");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.JournalDetails)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalDetail_Voucher");
        });

        modelBuilder.Entity<LineItem>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("LineItem", "common", tb => tb.HasTrigger("Prevent_Update_LineItem_Trigger"));

            entity.HasIndex(e => e.Voucher, "_dta_index_LineItem_5_2038558596__K3");

            entity.HasIndex(e => new { e.Voucher, e.Article }, "_dta_index_LineItem_5_2038558596__K3_K4");

            entity.HasIndex(e => new { e.Voucher, e.Article, e.Code }, "_dta_index_LineItem_5_2038558596__K3_K4_K2_5_6_7_8_13");

            entity.HasIndex(e => new { e.Article, e.Voucher }, "_dta_index_LineItem_5_2038558596__K4_K3");

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Article)
                .HasMaxLength(26)
                .HasColumnName("article");
            entity.Property(e => e.CalculatedCost)
                .HasColumnType("money")
                .HasColumnName("calculatedCost");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("quantity");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("money")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxableAmount)
                .HasColumnType("money")
                .HasColumnName("taxableAmount");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("money")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UnitAmt)
                .HasColumnType("money")
                .HasColumnName("unitAmt");
            entity.Property(e => e.Uom)
                .HasMaxLength(26)
                .HasColumnName("UOM");
            entity.Property(e => e.Voucher)
                .HasMaxLength(26)
                .HasColumnName("voucher");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.LineItems)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItem_Article");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.LineItems)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItem_Voucher");
        });

        modelBuilder.Entity<LineItemReference>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("LineItemReference", "common");

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LineItem)
                .HasMaxLength(26)
                .HasColumnName("lineItem");
            entity.Property(e => e.Referenced)
                .HasMaxLength(26)
                .HasColumnName("referenced");
            entity.Property(e => e.ReferingVouDfn).HasColumnName("referingVouDfn");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("value");

            entity.HasOne(d => d.LineItemNavigation).WithMany(p => p.LineItemReferenceLineItemNavigations)
                .HasForeignKey(d => d.LineItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemReference_LineItem1");

            entity.HasOne(d => d.ReferencedNavigation).WithMany(p => p.LineItemReferenceReferencedNavigations)
                .HasForeignKey(d => d.Referenced)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineItemReference_LineItem");
        });

        modelBuilder.Entity<NonCashTransaction>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("NonCashTransaction", "common");

            entity.HasIndex(e => e.Code, "IX_NonCashTransaction").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.Consignee)
                .HasMaxLength(26)
                .HasColumnName("consignee");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(26)
                .HasColumnName("currencyCode");
            entity.Property(e => e.DepositRef)
                .HasMaxLength(100)
                .HasColumnName("depositRef");
            entity.Property(e => e.Executed).HasColumnName("executed");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.IsIncoming).HasColumnName("isIncoming");
            entity.Property(e => e.IssueDate)
                .HasColumnType("datetime")
                .HasColumnName("issueDate");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("maturityDate");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .HasColumnName("number");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(26)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.PaymentProcesser)
                .HasMaxLength(26)
                .HasColumnName("paymentProcesser");
            entity.Property(e => e.Rate)
                .HasColumnType("money")
                .HasColumnName("rate");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Voucher)
                .HasMaxLength(26)
                .HasColumnName("voucher");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.NonCashTransactionConsigneeNavigations)
                .HasForeignKey(d => d.Consignee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_Organization");

            entity.HasOne(d => d.Consignee1).WithMany(p => p.NonCashTransactions)
                .HasForeignKey(d => d.Consignee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_OrganizationUnit");

            entity.HasOne(d => d.Consignee2).WithMany(p => p.NonCashTransactions)
                .HasForeignKey(d => d.Consignee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_Person");

            entity.HasOne(d => d.PaymentProcesserNavigation).WithMany(p => p.NonCashTransactionPaymentProcesserNavigations)
                .HasForeignKey(d => d.PaymentProcesser)
                .HasConstraintName("FK_NonCashTransaction_PaymentProcessor");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.NonCashTransactions)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonCashTransaction_Voucher");
        });

        modelBuilder.Entity<ObjectState>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ObjectState", "common");

            entity.HasIndex(e => e.Code, "IX_ObjectState").IsUnique();

            entity.HasIndex(e => new { e.Reference, e.ObjectStateDefinition }, "_dta_index_ObjectState_5_1883869778__K3_K4");

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ObjectStateDefinition)
                .HasMaxLength(26)
                .HasColumnName("objectStateDefinition");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.ObjectStates)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjectState_Article");

            entity.HasOne(d => d.Reference1).WithMany(p => p.ObjectStates)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjectState_Organization");

            entity.HasOne(d => d.Reference2).WithMany(p => p.ObjectStates)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjectState_Person");

            entity.HasOne(d => d.Reference3).WithMany(p => p.ObjectStates)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjectState_Vouchers");
        });

        modelBuilder.Entity<OptionalCode>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("OptionalCode", "common");

            entity.HasIndex(e => e.Code, "IX_OptionalCode").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Article)
                .HasMaxLength(26)
                .HasColumnName("article");
            entity.Property(e => e.CodeValue)
                .HasMaxLength(50)
                .HasColumnName("codeValue");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.OptionalCodes)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OptionalCode_Article");

            entity.HasOne(d => d.Article1).WithMany(p => p.OptionalCodes)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OptionalCode_Organization");

            entity.HasOne(d => d.Article2).WithMany(p => p.OptionalCodes)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OptionalCode_Person");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Organization", "common");

            entity.HasIndex(e => e.Type, "Gsl_Type_Index");

            entity.HasIndex(e => e.Code, "IX_Organization").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.BrandName).HasColumnName("brandName");
            entity.Property(e => e.BusinessType)
                .HasMaxLength(26)
                .HasColumnName("businessType");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Preference)
                .HasMaxLength(26)
                .HasColumnName("preference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.TradeName).HasColumnName("tradeName");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<OrganizationUnit>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("OrganizationUnit", "common");

            entity.HasIndex(e => e.Code, "IX_OrganizationUnit").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Component)
                .HasMaxLength(26)
                .HasColumnName("component");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.OrganizationUnitDefinition)
                .HasMaxLength(26)
                .HasColumnName("organizationUnitDefinition");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");

            entity.HasOne(d => d.OrganizationUnitDefinitionNavigation).WithMany(p => p.OrganizationUnits)
                .HasForeignKey(d => d.OrganizationUnitDefinition)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizationUnit_OrganizationUnitDefinition");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.OrganizationUnits)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizationUnit_Organization");
        });

        modelBuilder.Entity<OrganizationUnitDefinition>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("OrganizationUnitDefinition", "common");

            entity.HasIndex(e => e.Code, "IX_OrganizationUnitDefinition").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Abbriviation)
                .HasMaxLength(26)
                .HasColumnName("abbriviation");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ParentId)
                .HasMaxLength(26)
                .HasColumnName("parentId");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Specialization)
                .HasMaxLength(50)
                .HasColumnName("specialization");
            entity.Property(e => e.Type)
                .HasMaxLength(26)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Person", "common");

            entity.HasIndex(e => e.Type, "GSL_Type_Index");

            entity.HasIndex(e => e.Code, "IX_Person").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.FirstName).HasColumnName("firstName");
            entity.Property(e => e.Gender)
                .HasMaxLength(26)
                .HasColumnName("gender");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("lastName");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .HasColumnName("maritalStatus");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .HasColumnName("middleName");
            entity.Property(e => e.Nationality)
                .HasMaxLength(26)
                .HasColumnName("nationality");
            entity.Property(e => e.Preference)
                .HasMaxLength(26)
                .HasColumnName("preference");
            entity.Property(e => e.Religion)
                .HasMaxLength(26)
                .HasColumnName("religion");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Title)
                .HasMaxLength(26)
                .HasColumnName("title");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<ProductExtension>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ProductExtension", "common");

            entity.HasIndex(e => e.Code, "IX_ProductExtension").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Article)
                .HasMaxLength(26)
                .HasColumnName("article");
            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .HasColumnName("brand");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .HasColumnName("color");
            entity.Property(e => e.Country)
                .HasMaxLength(26)
                .HasColumnName("country");
            entity.Property(e => e.Generic)
                .HasMaxLength(100)
                .HasColumnName("generic");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(100)
                .HasColumnName("manufacturer");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Size)
                .HasMaxLength(25)
                .HasColumnName("size");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.ProductExtensions)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductExtension_Article");
        });

        modelBuilder.Entity<Relation>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Relation", "common");

            entity.HasIndex(e => e.Code, "IX_Relation").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ReferenceObject)
                .HasMaxLength(26)
                .HasColumnName("referenceObject");
            entity.Property(e => e.ReferringObject)
                .HasMaxLength(26)
                .HasColumnName("referringObject");
            entity.Property(e => e.RelationLevel)
                .HasMaxLength(25)
                .HasColumnName("relationLevel");
            entity.Property(e => e.RelationType)
                .HasMaxLength(26)
                .HasColumnName("relationType");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");

            entity.HasOne(d => d.ReferenceObjectNavigation).WithMany(p => p.Relations)
                .HasForeignKey(d => d.ReferenceObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relation_Article");

            entity.HasOne(d => d.ReferenceObject1).WithMany(p => p.Relations)
                .HasForeignKey(d => d.ReferenceObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relation_Organization");

            entity.HasOne(d => d.ReferenceObject2).WithMany(p => p.Relations)
                .HasForeignKey(d => d.ReferenceObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relation_Person");

            entity.HasOne(d => d.ReferenceObject3).WithMany(p => p.Relations)
                .HasForeignKey(d => d.ReferenceObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Relation_Vouchers");
        });

        modelBuilder.Entity<SerialDefinition>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("SerialDefinition", "common");

            entity.HasIndex(e => e.Code, "IX_SerialDefinition").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Article)
                .HasMaxLength(26)
                .HasColumnName("article");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IsMandantory).HasColumnName("isMandantory");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.SerialDefinitions)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerialDefinition_Article");
        });

        modelBuilder.Entity<StockBalance>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("StockBalance", "common");

            entity.HasIndex(e => e.Code, "IX_StockBalance").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Article)
                .HasMaxLength(26)
                .HasColumnName("article");
            entity.Property(e => e.Batch)
                .HasMaxLength(100)
                .HasColumnName("batch");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Period)
                .HasMaxLength(26)
                .HasColumnName("period");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(18, 7)")
                .HasColumnName("quantity");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Store)
                .HasMaxLength(26)
                .HasColumnName("store");
            entity.Property(e => e.Type)
                .HasMaxLength(26)
                .HasColumnName("type");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.StockBalances)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockBalance_Article");

            entity.HasOne(d => d.StoreNavigation).WithMany(p => p.StockBalances)
                .HasForeignKey(d => d.Store)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockBalance_OrganizationUnitDefinition");
        });

        modelBuilder.Entity<StockLevel>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("StockLevel", "common");

            entity.HasIndex(e => e.Code, "IX_StockLevel").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Article)
                .HasMaxLength(26)
                .HasColumnName("article");
            entity.Property(e => e.EconomicOrderQty)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("economicOrderQty");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LeadTime)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("leadTime");
            entity.Property(e => e.MaxLevel)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("maxLevel");
            entity.Property(e => e.MinLevel)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("minLevel");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Store)
                .HasMaxLength(26)
                .HasColumnName("store");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.StockLevels)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockLevel_Article");

            entity.HasOne(d => d.StoreNavigation).WithMany(p => p.StockLevels)
                .HasForeignKey(d => d.Store)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockLevel_OrganizationUnitDefinition");
        });

        modelBuilder.Entity<StoreTransaction>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("StoreTransaction", "common");

            entity.HasIndex(e => e.Code, "IX_StoreTransaction").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Destination)
                .HasMaxLength(26)
                .HasColumnName("destination");
            entity.Property(e => e.HasEffet).HasColumnName("hasEffet");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Source)
                .HasMaxLength(26)
                .HasColumnName("source");
            entity.Property(e => e.Voucher)
                .HasMaxLength(26)
                .HasColumnName("voucher");

            entity.HasOne(d => d.DestinationNavigation).WithMany(p => p.StoreTransactionDestinationNavigations)
                .HasForeignKey(d => d.Destination)
                .HasConstraintName("FK_StoreTransaction_OrganizationUnitDefinitionSource");

            entity.HasOne(d => d.SourceNavigation).WithMany(p => p.StoreTransactionSourceNavigations)
                .HasForeignKey(d => d.Source)
                .HasConstraintName("FK_StoreTransaction_OrganizationUnitDefinitionDestination");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.StoreTransactions)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreTransaction_Voucher");
        });

        modelBuilder.Entity<TaxTransaction>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("TaxTransaction", "common", tb => tb.HasTrigger("Prevent_Update_TaxTrx_Trigger"));

            entity.HasIndex(e => e.Code, "IX_TaxTransaction").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("money")
                .HasColumnName("taxAmount");
            entity.Property(e => e.TaxType).HasColumnName("taxType");
            entity.Property(e => e.TaxableAmount)
                .HasColumnType("money")
                .HasColumnName("taxableAmount");
            entity.Property(e => e.Voucher)
                .HasMaxLength(26)
                .HasColumnName("voucher");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.TaxTransactions)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxTransaction_Voucher");
        });

        modelBuilder.Entity<TransactionLimit>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("TransactionLimit", "common");

            entity.Property(e => e.Code).HasMaxLength(26);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LimitFactor)
                .HasMaxLength(26)
                .HasColumnName("limitFactor");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(26)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("value");

            entity.HasOne(d => d.ReferenceNavigation).WithMany(p => p.TransactionLimits)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionLimit_Article");

            entity.HasOne(d => d.Reference1).WithMany(p => p.TransactionLimits)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionLimit_Organization");

            entity.HasOne(d => d.Reference2).WithMany(p => p.TransactionLimits)
                .HasForeignKey(d => d.Reference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionLimit_Person");
        });

        modelBuilder.Entity<TransactionReference>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_TransactionReference_1");

            entity.ToTable("TransactionReference", "common");

            entity.HasIndex(e => e.Code, "IX_TransactionReference").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Referenced)
                .HasMaxLength(26)
                .HasColumnName("referenced");
            entity.Property(e => e.Referening)
                .HasMaxLength(26)
                .HasColumnName("referening");
            entity.Property(e => e.RelationType)
                .HasMaxLength(50)
                .HasColumnName("relationType");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Value)
                .HasColumnType("money")
                .HasColumnName("value");

            entity.HasOne(d => d.ReferencedNavigation).WithMany(p => p.TransactionReferenceReferencedNavigations)
                .HasForeignKey(d => d.Referenced)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionReference_TransactionReference");

            entity.HasOne(d => d.RefereningNavigation).WithMany(p => p.TransactionReferenceRefereningNavigations)
                .HasForeignKey(d => d.Referening)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionReference_TransactionReference1");
        });

        modelBuilder.Entity<Value>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Value", "common");

            entity.HasIndex(e => e.Code, "IX_Value").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Article)
                .HasMaxLength(26)
                .HasColumnName("article");
            entity.Property(e => e.Component)
                .HasMaxLength(26)
                .HasColumnName("component");
            entity.Property(e => e.Currency)
                .HasMaxLength(26)
                .HasColumnName("currency");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.PriceValue)
                .HasColumnType("money")
                .HasColumnName("priceValue");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Reference)
                .HasMaxLength(26)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");

            entity.HasOne(d => d.ArticleNavigation).WithMany(p => p.Values)
                .HasForeignKey(d => d.Article)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Value_Article");
        });


        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Voucher", "common", tb => tb.HasTrigger("Prevent_Update_Trigger"));

            entity.HasIndex(e => e.Date, "Date_Index");

            entity.HasIndex(e => e.Code, "IX_Voucher").IsUnique();

            entity.HasIndex(e => e.Month, "MonthIndex");

            entity.HasIndex(e => e.VoucherDefinition, "Voucher_Definition_Index");

            entity.HasIndex(e => e.Year, "Year_Index");

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Component)
                .HasMaxLength(26)
                .HasColumnName("component");
            entity.Property(e => e.Consignee)
                .HasMaxLength(26)
                .HasColumnName("consignee");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("money")
                .HasColumnName("grandTotal");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IssuedDate).HasColumnType("datetime");
            entity.Property(e => e.LastActivity)
                .HasMaxLength(26)
                .HasColumnName("lastActivity");
            entity.Property(e => e.LastObjectState).HasMaxLength(26);
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Period)
                .HasMaxLength(26)
                .HasColumnName("period");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(26)
                .HasColumnName("type");
            entity.Property(e => e.VoucherDefinition).HasColumnName("voucherDefinition");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.ConsigneeNavigation).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.Consignee)
                .HasConstraintName("FK_Voucher_Organization");

            entity.HasOne(d => d.Consignee1).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.Consignee)
                .HasConstraintName("FK_Voucher_Person");
        });

        modelBuilder.Entity<VoucherExtensionTransaction>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VoucherExtensionTransaction", "common");

            entity.HasIndex(e => e.Code, "IX_VoucherExtensionTransaction").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Number)
                .HasMaxLength(26)
                .HasColumnName("number");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Voucher)
                .HasMaxLength(26)
                .HasColumnName("voucher");
            entity.Property(e => e.VoucherExtension)
                .HasMaxLength(26)
                .HasColumnName("voucherExtension");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.VoucherExtensionTransactions)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherExtensionTransaction_Voucher");
        });

        modelBuilder.Entity<VoucherNote>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VoucherNote", "common");

            entity.HasIndex(e => e.Code, "IX_VoucherNote").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Voucher)
                .HasMaxLength(26)
                .HasColumnName("voucher");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.VoucherNotes)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherNote_Voucher");
        });

        modelBuilder.Entity<VoucherTerm>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VoucherTerm", "common");

            entity.HasIndex(e => e.Code, "IX_VoucherTerm").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(26)
                .HasColumnName("code");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Term)
                .HasMaxLength(26)
                .HasColumnName("term");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.Voucher)
                .HasMaxLength(26)
                .HasColumnName("voucher");

            entity.HasOne(d => d.VoucherNavigation).WithMany(p => p.VoucherTerms)
                .HasForeignKey(d => d.Voucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherTerm_Voucher");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

